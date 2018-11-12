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
		/// <summary>
		/// Custom Container for elements in equation class.
		/// </summary>
		private class Equation_Elements : IEnumerable
		{
			private List<IElement> Elements_List;

			/// <summary>
			/// Constructor, that initialize empty element list for container.
			/// </summary>
			public Equation_Elements()
			{
				Elements_List = new List<IElement>();
			}

			/// <summary>
			/// Constructor, that initialize element list of passed list for container.
			/// </summary>
			public Equation_Elements(List<IElement> _Element_List)
			{
				Elements_List = _Element_List;
			}

			/// <summary>
			/// Adds new element to container list.
			/// </summary>
			public void Add(IElement _Element)
			{
				Elements_List.Add(_Element);
			}

			/// <summary>
			/// Gets number of elements in colection.
			/// </summary>
			public int Count
			{
				get { return Elements_List.Count; }
			}

			/// <summary>
			/// Gets element with given index.
			/// </summary>
			public IElement this[int index]
			{
				get { return Elements_List[index]; }
			}

			/// <summary>
			/// Inserts given element into given index position.
			/// </summary>
			/// <exception cref="ArgumentOutOfRangeException">
			public void Insert(int index, IElement _Element)
			{
				Elements_List.Insert(index, _Element);
			}

			/// <summary>
			/// Returns index in coletion list of given element.
			/// </summary>
			public int IndexOf(IElement _Element)
			{
				return Elements_List.IndexOf(_Element);
			}

			/// <summary>
			/// Returns new element list of elements in given range.
			/// </summary>
			/// <param name="index"></param>
			/// <param name="count"></param>
			/// <returns></returns>
			public List<IElement> GetRange(int index, int count)
			{
				return Elements_List.GetRange(index, count);
			}

			/// <summary>
			/// Replaces given range in container list by given element
			/// </summary>
			public void ReplaceRange(int index, int count, IElement _Element)
			{
				Elements_List.RemoveRange(index, count);
				Elements_List.Insert(index, _Element);
			}

			/// <summary>
			/// Removes removes element whit passed number index
			/// Returns true if everything true if removed element was not last element in coletion,
			/// returns false when element was last in coletion. 
			/// </summary>
			public bool RemoveAt(int item_Index)
			{
				Elements_List.RemoveAt(item_Index);

				return (item_Index < Elements_List.Count && 0 < Elements_List.Count);
			}

			/// <summary>
			/// Returns enumerator of this container list.
			/// </summary>
			/// <returns></returns>
			public IEnumerator GetEnumerator()
			{
				return ((IEnumerable)Elements_List).GetEnumerator();
			}
		}

		/// <summary>
		/// Custom enumerator for pointed Equation_Elements.
		/// </summary>
		private class Elements_Enumerator : IEnumerator
		{
			private Equation_Elements Coletion;

			public int Current_Index { get; private set; }

			/// <summary>
			/// Constructs elements' enumerator of given coletion.
			/// </summary>
			public Elements_Enumerator(Equation_Elements Elements_Coletion)
			{
				Coletion = Elements_Coletion;
				Reset();
			}

			/// <summary>
			/// Returns element pointed by current index as object for foreach loops.
			/// </summary>
			public object Current
			{
				get
				{
					return Current_Element;
				}
			}

			/// <summary>
			/// Returns element pointed by current index.
			/// </summary>
			public IElement Current_Element
			{
				get
				{
					if (Current_Index >= Coletion.Count || Current_Index < 0)
						return default(IElement);
					else
						return Coletion[Current_Index];
				}
			}

			/// <summary>
			/// Returns element previous to element pointed by current index.
			/// </summary>
			public IElement Previous_Element
			{
				get
				{
					if (Current_Index > Coletion.Count || Current_Index < 1)
						return default(IElement);
					else
						return Coletion[Current_Index - 1];
				}
			}

			/// <summary>
			/// Decrements value of current index pointer of this enumenrator but not lower than -1.
			/// </summary>
			public static Elements_Enumerator operator --(Elements_Enumerator _Elements_Enumerator)
			{
				if (_Elements_Enumerator.Current_Index > -2)
					_Elements_Enumerator.Current_Index--;
				return _Elements_Enumerator;
			}

			/// <summary>
			/// Increments value of current index pointer of this enumenrator and returns true until index point 
			/// </summary>
			public bool MoveNext()
			{
				return ++Current_Index >= Coletion.Count;
			}

			/// <summary>
			/// Resets this enumerator setting index pointer to value -1.
			/// </summary>
			public void Reset()
			{
				Current_Index = -1;
			}
		}
	}
}
