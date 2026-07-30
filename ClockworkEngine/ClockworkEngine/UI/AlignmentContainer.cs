using System.Collections.Generic;
using System;

namespace Clockwork.UI;

public class AlignmentContainer : Container
{
	private Dictionary<Element, Alignment> alignments = new();

	public override void AddChild(Element element)
	{
		base.AddChild(element);
		alignments[element] = new();
	}

	public override void InsertChild(int index, Element element)
	{
		base.InsertChild(index, element);
		alignments[element] = new();
	}

	public override void RemoveChild(Element element)
	{
		base.RemoveChild(element);
		alignments.Remove(element);
	}

	public void SetAlignment(Element element, Alignment alignment)
	{
		if (!alignments.ContainsKey(element)) throw new Exception($"Element {element} is not a child of this alignment container.");
		alignments[element] = alignment;

		AlignElement(element, alignment.Horizontal);
		AlignElement(element, alignment.Vertical);
	}

	private void AlignElement(Element element, HorizontalAlignment horizontalAlignment)
	{
		switch (horizontalAlignment)
		{
			case HorizontalAlignment.Left:
				element.X = X + PaddingLeft;
				break;
			case HorizontalAlignment.Center:
				element.X = X + GetHalfWidth() - element.GetHalfWidth();
				break;
			case HorizontalAlignment.Right:
				element.X = X + Width - PaddingRight - element.Width;
				break;
		}
	}

	private void AlignElement(Element element, VerticalAlignment verticalAlignment)
	{
		switch (verticalAlignment)
		{
			case VerticalAlignment.Top:
				element.Y = Y + PaddingTop;
				break;
			case VerticalAlignment.Center:
				element.Y = Y + GetHalfHeight() - element.GetHalfHeight();
				break;
			case VerticalAlignment.Bottom:
				element.Y = Y + Height - PaddingBottom - element.Height;
				break;
		}
	}

	protected override void OnXUpdated()
	{
		foreach (KeyValuePair<Element, Alignment> elementAlignmentPair in alignments)
		{
			Element element = elementAlignmentPair.Key;
			Alignment alignment = elementAlignmentPair.Value;
			AlignElement(element, alignment.Horizontal);
		}
	}

	protected override void OnYUpdated()
	{
		foreach (KeyValuePair<Element, Alignment> elementAlignmentPair in alignments)
		{
			Element element = elementAlignmentPair.Key;
			Alignment alignment = elementAlignmentPair.Value;
			AlignElement(element, alignment.Vertical);
		}
	}

	protected override void OnWidthUpdated()
	{
		foreach (KeyValuePair<Element, Alignment> elementAlignmentPair in alignments)
		{
			Element element = elementAlignmentPair.Key;
			Alignment alignment = elementAlignmentPair.Value;
			AlignElement(element, alignment.Horizontal);
		}
	}

	protected override void OnHeightUpdated()
	{
		foreach (KeyValuePair<Element, Alignment> elementAlignmentPair in alignments)
		{
			Element element = elementAlignmentPair.Key;
			Alignment alignment = elementAlignmentPair.Value;
			AlignElement(element, alignment.Vertical);
		}
	}
}
