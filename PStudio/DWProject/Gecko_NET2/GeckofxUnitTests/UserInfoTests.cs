﻿using System;
using System.Collections.Generic;
using BaseTypes = Gecko.BaseTypes;
using System.Runtime.InteropServices;
using System.Text;
using NUnit.Framework;
using Gecko;

namespace GeckofxUnitTests
{
	[TestFixture]
	[Platform(Exclude="Linux")]
	public class UserInfoTests
	{
		nsIUserInfo m_instance;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			m_instance = Xpcom.CreateInstance<nsIUserInfo>("@mozilla.org/userinfo;1");
			Assert.IsNotNull(m_instance);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			Marshal.ReleaseComObject(m_instance);
		}		

		[Test]
		public void GetFullnameAttribute_ThrowsNotImplementException()
		{
			Assert.Throws<NotImplementedException>(() => m_instance.GetFullnameAttribute());
		}

		[Test]
		public void GetEmailAddressAttribute_ThrowsNotImplementException()
		{
			Assert.Throws<NotImplementedException>(() => m_instance.GetEmailAddressAttribute());
		}

		[Test]
		public void GetDomainAttribute_ThrowsNotImplementedException()
		{
			Assert.Throws<NotImplementedException>(() => m_instance.GetDomainAttribute());			
		}
	}
}