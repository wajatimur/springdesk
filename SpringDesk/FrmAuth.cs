using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace SpringDesk
{
    public partial class FrmAuth : Form
    {

        public FrmAuth()
        {
            InitializeComponent();

            // Assign to local var
            Springpad springPad = Globals.springPadObject;

            // If request token is null then request one
            if (springPad.RequestToken == null)
            {
                // Start local server listener for callback processing
                String callBackUrl = serverStart();
                springPad.callBackUrl = callBackUrl;

                // Get request token and navigate authorization link
                springPad.RequestAuthorization();
                if( springPad.RequestToken != null) webBrowser.Navigate(Globals.springPadObject.authorizationLink);
            }
        }


        /**
         * Embedded Http Server 
         * 
         *  
         * http://netrsc.blogspot.com/2009/09/worlds-smallest-web-server-in-c.html
         * http://knitinr.blogspot.com/2008/06/using-httplistener-class.html
         * 
         **/

        private static System.Threading.AutoResetEvent listenForNextRequest = new System.Threading.AutoResetEvent(false);
        private HttpListener httpServer;

        public string serverStart()
        {
            var rnd = new Random();
            int serverPort = rnd.Next(50000, 60000);

            String serverPrefix = "http://localhost:" + serverPort.ToString() + "/";

            httpServer = new HttpListener();
            httpServer.Prefixes.Add(serverPrefix);
            httpServer.Start();
            System.Threading.ThreadPool.QueueUserWorkItem(serverListen);

            return serverPrefix;
        }

        public void serverListen(object result)
        {
            while (httpServer.IsListening)
            {
                httpServer.BeginGetContext(new AsyncCallback(serverCallback), httpServer);
                listenForNextRequest.WaitOne();
            }
        }

        public void serverCallback(IAsyncResult result)
        {
            HttpListener listener = result.AsyncState as HttpListener;
            HttpListenerContext context = listener.EndGetContext(result);

            listenForNextRequest.Set();

            byte[] byteArr = System.Text.ASCIIEncoding.ASCII.GetBytes("Authorization complete!");
            context.Response.OutputStream.Write(byteArr, 0, byteArr.Length);
            context.Response.Close();

            // Request access token
            Globals.springPadObject.RequestAccess();

        }

    }
}
