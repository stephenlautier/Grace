﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grace.DependencyInjection.Exceptions
{
	/// <summary>
	/// This is a General catch all exception that normally wraps another exception throw while 
	/// </summary>
	public class GeneralLocateException : LocateException
	{
		/// <summary>
		/// Default constructor takes information about what was happening at the moment the exception was caught
		/// </summary>
		/// <param name="locateName">name to use when locating</param>
		/// <param name="locatingType">type used when locating</param>
		/// <param name="currentContext">current context</param>
		/// <param name="innerException">inner exception</param>
		public GeneralLocateException(string locateName, Type locatingType, IInjectionContext currentContext, Exception innerException) :
			base(locateName, locatingType, currentContext, innerException)
		{
			
		}
	}
}