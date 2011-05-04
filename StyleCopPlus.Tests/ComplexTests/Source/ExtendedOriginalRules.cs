﻿#region ElementMustNotBeOnSingleLine // SP1502

//# [OK]
//# Well-formed example.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		public TestClass()
		{
		}
	}
}
//# [END]

//# [OK]
//# Special style for constructors.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		public TestClass()
		{ }
	}
}
//# [END]

//# [OK]
//# Special style for constructors.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		public TestClass() { }
	}
}
//# [END]

#endregion

#region OpeningCurlyBracketsMustNotBePrecededByBlankLine // SP1509

//# [OK]
//# Well-formed example.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		public void TestMethod()
		{
			for (int i = 0; i < 10; i++)
			{
			}
		}
	}
}
//# [END]

//# [ERROR]
//# Excess blank line.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		public void TestMethod()
		{
			for (int i = 0; i < 10; i++)

			{
			}
		}
	}
}
//# [END]

//# [ERROR]
//# Excess blank line.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		public void TestMethod()
		{
			int[] a = new int[]

			{
				10,
				20
			};
		}
	}
}
//# [END]

//# [OK]
//# Well-formed nested blocks.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		public void TestMethod()
		{
			{
				int a = 10;
			}

			{
				int a = 10;
			}
		}
	}
}
//# [END]

//# [OK]
//# Well-formed nested blocks with declarations.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		public void TestMethod()
		{
			int a = 10;

			{
				int a = 10;
			}

			int b = 10;

			{
				int a = 10;
			}
		}
	}
}
//# [END]

//# [OK]
//# Well-formed nested blocks with comments.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		public void TestMethod()
		{
			int a = 10;

			// comment
			{
				int a = 10;
			}

			int b = 10;

			// comment
			{
				int a = 10;
			}
		}
	}
}
//# [END]

//# [OK]
//# Well-formed nested blocks with several declarations.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		public void TestMethod()
		{
			int a = 10;
			int b = 10;

			int c = 10;
			int d = 10;

			for (int i = 0; i < 10; i++)
			{
				int a = 10;
				int b = 10;
			}

			int e = 10;
			int f = 10;

			{
				int a = 10;
				int b = 10;
			}

			int g = 10;
			int h = 10;
		}
	}
}
//# [END]

#endregion

#region ClosingCurlyBracketMustBeFollowedByBlankLine // SP1513

//# [OK]
//# Well-formed example.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		public void TestMethod()
		{
			for (int i = 0; i < 10; i++)
			{
			}

			for (int i = 0; i < 10; i++)
			{
			}
		}
	}
}
//# [END]

//# [ERROR]
//# There should be blank line between two cycles.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		public void TestMethod()
		{
			for (int i = 0; i < 10; i++)
			{
			}
			for (int i = 0; i < 10; i++)
			{
			}
		}
	}
}
//# [END]

//# [OK]
//# Original style for accessors.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		private int m_field;

		public int TestProperty
		{
			get
			{
				return m_field;
			}

			set
			{
				m_field = value;
			}
		}
	}
}
//# [END]

//# [OK]
//# Special style for accessors.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		private int m_field;

		public int TestProperty
		{
			get
			{
				return m_field;
			}
			set
			{
				m_field = value;
			}
		}
	}
}
//# [END]

//# [OK]
//# Special style for accessors.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		private int m_field;

		public int TestProperty
		{
			set
			{
				m_field = value;
			}
			get
			{
				return m_field;
			}
		}
	}
}
//# [END]

#endregion

#region ElementsMustBeSeparatedByBlankLine // SP1516

//# [OK]
//# Well-formed example.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		public void TestMethod1()
		{
			int a = 10;
		}

		public void TestMethod2()
		{
			int a = 10;
		}
	}
}
//# [END]

//# [ERROR]
//# There should be blank line between two methods.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		public void TestMethod1()
		{
			int a = 10;
		}
		public void TestMethod2()
		{
			int a = 10;
		}
	}
}
//# [END]

//# [OK]
//# Original style for accessors.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		private int m_field;

		public int TestProperty
		{
			get
			{
				return m_field;
			}

			set
			{
				m_field = value;
			}
		}
	}
}
//# [END]

//# [OK]
//# Special style for accessors.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		private int m_field;

		public int TestProperty
		{
			get
			{
				return m_field;
			}
			set
			{
				m_field = value;
			}
		}
	}
}
//# [END]

//# [OK]
//# Special style for accessors.
namespace StyleCopPlus.Tests
{
	public class TestClass
	{
		private int m_field;

		public int TestProperty
		{
			set
			{
				m_field = value;
			}
			get
			{
				return m_field;
			}
		}
	}
}
//# [END]

#endregion
