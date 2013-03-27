using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using DevDefined.OAuth.Framework;
using DevDefined.OAuth.Consumer;
using DevDefined.OAuth.Tests;
using Newtonsoft.Json.Linq;


namespace SpringDesk
{
    public class Springpad
    {
        string baseUrl = "http://springpad.com/api";
        string requestUrl = "http://springpad.com/api/oauth-request-token";
        string userAuthorizeUrl = "http://springpad.com/api/oauth-authorize";
        string accessUrl = "http://springpad.com/api/oauth-access-token";
        public string callBackUrl = "http://localhost/";
        public string authorizationLink = "";

        string consumerKey = "96c8b4d0ec244acc858730bdecf73cb7";
        string consumerPrivate = "77c6f2b13da24bc4961be1869da22c5e";

        private IToken requestToken;
        private IToken accessToken;

        private OAuthSession session;

        public String RequestAuthorization()
        {
            //string authorizationLink = "";
            X509Certificate2 certificate = TestCertificates.OAuthTestCertificate();

            // Creating consumer context
            var consumerContext = new OAuthConsumerContext
            {
                ConsumerKey = this.consumerKey,
                ConsumerSecret = this.consumerPrivate,
                SignatureMethod = SignatureMethod.HmacSha1,
                Key = certificate.PrivateKey
            };

            // Creating session and get authorization url
            this.session = new OAuthSession(consumerContext, this.requestUrl, this.userAuthorizeUrl, this.accessUrl);
            IToken requestToken = this.session.GetRequestToken();
            this.authorizationLink = this.session.GetUserAuthorizationUrlForToken(requestToken, callBackUrl);

            // Return request token and authorization link
            this.requestToken = requestToken;
            return this.authorizationLink;
        }


        public Boolean RequestAccess()
        {
            Boolean tokenGranted = false;

            if( this.authorizationLink != "")
            {
                this.accessToken = this.session.ExchangeRequestTokenForAccessToken(this.requestToken);
                tokenGranted = true;
            }

            return tokenGranted;
        }


        public String WebGetAsString(String url)
        {
            String dataString = session.Request().Get().ForUrl(this.baseUrl + url).ToString();
            //HttpWebResponse webResponse = session.Request().Get().ForUrl(this.baseUrl + url).ToWebResponse();
            //Encoding enc = System.Text.Encoding.GetEncoding(1252);
            //StreamReader ioResponseStream = new StreamReader(webResponse.GetResponseStream(), enc);

            HttpWebResponse webResponse = session.Request().Get().ForUrl(this.baseUrl + url).ToWebResponse();
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            StreamReader ioResponseStream = new StreamReader(webResponse.GetResponseStream(), enc);

            //byte[] byteArr = session.Request().Get().ForUrl(this.baseUrl + url).ToBytes();
            //System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            //dataString = enc.GetString(byteArr);

            //dataString = dataString.Replace("\n", string.Empty);
            return ioResponseStream.ReadToEnd() ;
            //return dataString;
        }


        public JObject WebGetAsJson(String url)
        {
            String dataString = WebGetAsString(url);
            return JObject.Parse(dataString);
            
        }

        public IToken AccessToken
        {
            get { return accessToken; }
            set { accessToken = value; }
        }


        public IToken RequestToken
        {
            get { return requestToken; }
            set { requestToken = value; }
        }
    
    }

}
