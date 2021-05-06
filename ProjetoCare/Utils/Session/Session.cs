using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCare.Utils.Session
{
	public class Session
	{
		private readonly IHttpContextAccessor _ctx;
		public Session(IHttpContextAccessor _ctx)
		{
			this._ctx = _ctx;
		}

        public void Insert(string key, string value)
        {
            _ctx.HttpContext.Session.SetString(key, value);
        }

        public string Search(string key)
        {
            return _ctx.HttpContext.Session.GetString(key);
        }

        public bool Exists(string key)
        {
            if (_ctx.HttpContext.Session.Get(key) == null)
            {
                return false;
            }

            return true;
        }

        public void Remove(string key)
        {
            _ctx.HttpContext.Session.Remove(key);
        }


    }
}
