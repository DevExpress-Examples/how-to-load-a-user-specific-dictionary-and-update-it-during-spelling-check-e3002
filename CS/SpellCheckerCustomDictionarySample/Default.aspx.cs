using System;
using System.IO;
using System.Text;
#region #usings
using DevExpress.Web.ASPxSpellChecker;
using DevExpress.XtraSpellChecker;
#endregion #usings

namespace SpellCheckerCustomDictionarySample {
    public partial class Default : System.Web.UI.Page {
        string userDictPath;

        protected void Page_Load(object sender, EventArgs e) {
            userDictPath = GetUserDictionaryPath();
        }

        private string GetUserDictionaryPath() {
            string username = Request.ServerVariables["remote_user"];
            if (username == null)
                username = "anonymous";
            else
                username = username.Replace("\\", "_");
            string userDictName = "~/CustomDictionaries/" + username + ".dic";
            return Server.MapPath(userDictName);
        }
        #region #wordadded
        protected void ASPxSpellChecker1_WordAdded(object sender, WordAddedEventArgs e) {
            ASPxSpellChecker checker = sender as ASPxSpellChecker;
            SpellCheckerCustomDictionary dic = checker.GetCustomDictionary();
            if (dic != null) {
                StringBuilder stb = new StringBuilder();
                for (int i = 0; i < dic.WordCount; i++)
                    stb.AppendLine(dic[i]);
                using (StreamWriter writer = new StreamWriter(userDictPath)) {
                    writer.Write(stb.ToString());
                }
            }
        }
        #endregion #wordadded
        #region #customdictionaryloading
        protected void ASPxSpellChecker1_CustomDictionaryLoading(object sender, CustomDictionaryLoadingEventArgs e) {

            FileStream alphStream = new FileStream(Server.MapPath(e.CustomDictionary.AlphabetPath), FileMode.Open, FileAccess.Read);
            FileStream dicStream = new FileStream(userDictPath, FileMode.OpenOrCreate, FileAccess.Read);
            try {
                alphStream.Seek(0, SeekOrigin.Begin);
                dicStream.Seek(0, SeekOrigin.Begin);
                e.CustomDictionary.LoadFromStream(dicStream, alphStream);
            }
            finally {
                alphStream.Dispose();
                dicStream.Dispose();
            }
        }
        #endregion #customdictionaryloading
    }
}