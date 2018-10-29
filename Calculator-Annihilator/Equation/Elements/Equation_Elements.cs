using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		private class Equation_Elements : IEnumerable
		{
			static public List<IElement> Elements_List;

			public Equation_Elements()
			{
				Elements_List = new List<IElement>();
			}

			public void Add(IElement element)
			{
				Elements_List.Add(element);
			}

			public int Count
			{
				get { return Elements_List.Count; }
			}

			public IElement this[int index]
			{
				get { return Elements_List[index]; }
			}

			public void Insert(int index, IElement element)
			{
				Elements_List.Insert(index, element);
			}

			public int IndexOf(IElement element)
			{
				return Elements_List.IndexOf(element);
			}

			public List<IElement> GetRange(int index, int count)
			{
				return Elements_List.GetRange(index, count);
			}

			public void Clear()
			{
				Elements_List.Clear();
			}

			public IEnumerator GetEnumerator()
			{
				return ((IEnumerable)Elements_List).GetEnumerator();
			}
		}

		class Elements_Colections : IEnumerator
		{
			int rator;
			private Equation_Elements Coletion;

			public Elements_Colections(Equation_Elements EE)
			{
				Coletion = EE;
				Reset();
			}

			public object Current
			{
				get
				{
					if (rator >= Coletion.Count || rator < 0)
						return default(Equation_Elements);
					else
						return Coletion[rator];
				}
			}

			public bool MoveNext()
			{
				return ++rator >= Coletion.Count;
			}

			public void Reset()
			{
				rator = -1;
			}
		}
	}
}
