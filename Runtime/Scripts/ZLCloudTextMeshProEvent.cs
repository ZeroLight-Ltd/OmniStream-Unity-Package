#if PACKAGE_TMP || PACKAGE_UGUI
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZeroLight
{
	public class TextMeshProEvent
	{
		[RuntimeInitializeOnLoadMethod]
		static void LoadTextMeshProEvent()
		{
			ZeroLight.ZLCloudTextEvent.onTextEvent += OnTextEvent;
		}

		static void OnTextEvent(GameObject selectedObject, Event textEvent)
		{
			if (selectedObject.TryGetComponent(out TMPro.TMP_InputField tmpInputField))
			{
				tmpInputField.ProcessEvent(textEvent);
				tmpInputField.ForceLabelUpdate();
			}
		}
	}
}
#endif
