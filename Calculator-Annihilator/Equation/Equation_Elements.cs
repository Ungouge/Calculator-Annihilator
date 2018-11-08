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
			private List<IElement> Elements_List;

			public Equation_Elements()
			{
				Elements_List = new List<IElement>();
			}

			public Equation_Elements(List<IElement> el)
			{
				Elements_List = el;
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

			public void ReplaceRange(int index, int count, Number Result_Number)
			{
				Elements_List.RemoveRange(index, count);
				Elements_List.Insert(index, Result_Number);
			}

			public bool Remove(IElement Item)
			{
				int item_Index = Elements_List.IndexOf(Item);
				Elements_List.Remove(Item);

				if (item_Index < Elements_List.Count)
					return false;
				else
					return true;
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

		private class Elements_Enumerator : IEnumerator
		{
			private Equation_Elements Coletion;

			public int Current_Index { get; private set; }

			public Elements_Enumerator(Equation_Elements EE)
			{
				Coletion = EE;
				Reset();
			}

			public object Current
			{
				get
				{
					return Current_Element;
				}
			}

			public IElement Current_Element
			{
				get
				{
					if (Current_Index >= Coletion.Count || Current_Index < 0)
						return default(Element);
					else
						return Coletion[Current_Index];
				}
			}

			public bool MoveNext()
			{
				return ++Current_Index >= Coletion.Count;
			}

			public void Reset()
			{
				Current_Index = -1;
			}
		}
	}
}
