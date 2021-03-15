using AngleSharp.Dom;
using System.Linq;

namespace SearchEngine.Crawler
{
	internal static class ElementExtensions
	{
		public static bool HasZeroOrOneChild(this IElement element)
		{
			while (element.ChildElementCount == 1)
			{
				element = element.Children.First();
			}

			return element.ChildElementCount == 0;
		}

		public static IElement Flatten(this IElement element)
		{
			while (element.ChildElementCount == 1)
			{
				element = element.Children.First();
			}

			return element;
		}
	}
}
