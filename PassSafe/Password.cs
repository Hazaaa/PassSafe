using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassSafe
{
    public class Password
    {
        private String _siteName;
        private String _username;
        private String _pass;
        private String _siteURL;
        private String _fileName;

        [DisplayName("Site Name")]
        public String SiteName { get => _siteName; set => _siteName = value; }

        [DisplayName("Username/E-mail")]
        public String Username { get => _username; set => _username = value; }

        [DisplayName("Password")]
        public String Pass { get => _pass; set => _pass = value; }
        
        [Browsable(false)]
        public String SiteURL { get => _siteURL; set => _siteURL = value; }

        [Browsable(false)]
        public string FileName { get => _fileName; set => _fileName = value; }

        public Password() { }
        public Password(String naziv, String username, String password, String URL)
        {
            this._siteName = naziv;
            this._username = username;
            this._pass = password;
            this._siteURL = URL;
        }
    }
}
