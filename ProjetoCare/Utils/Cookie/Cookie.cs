using System;
using Microsoft.AspNetCore.Http;

namespace ProjetoCare.Utils.Cookie
{
    public class Cookie
    {
        IHttpContextAccessor ct;
        public Cookie(IHttpContextAccessor ct)
        {
            this.ct = ct;
        }

        /// <summary>
        /// insere cookie 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Insert(string key, string value)
        {
            CookieOptions cookie = new CookieOptions(){
                Expires = DateTime.Now.AddMinutes(15)
            };

            ct.HttpContext.Response.Cookies.Append(key, value, cookie);
            ct.HttpContext.Session.SetString(key, value);
        }


        /// <summary>
        /// Busca cookie cadastrado
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Search(string key)
        {
            return ct.HttpContext.Request.Cookies[key];
        }

        public bool Exists(string key)
        {
            if(ct.HttpContext.Request.Cookies[key] == null){
                return false;
            }

            return true;
        }


        /// <summary>
        /// Remove cookie
        /// </summary>
        /// <param name="key"></param>
        public void Remove(string key)
        {
            ct.HttpContext.Response.Cookies.Delete(key);
        }
    }
}