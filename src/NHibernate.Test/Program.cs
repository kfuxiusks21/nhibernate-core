﻿#if NETCOREAPP2_0_OR_GREATER
namespace NHibernate.Test
{
	public class Program
	{
		public static int Main(string[] args)
		{
			return new NUnitLite.AutoRun(typeof(Program).Assembly).Execute(args);
		}
	}
}
#endif