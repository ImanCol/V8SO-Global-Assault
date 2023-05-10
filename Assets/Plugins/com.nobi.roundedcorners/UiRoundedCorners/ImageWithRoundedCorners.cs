using UnityEngine;
using UnityEngine.UI;

namespace Nobi.UiRoundedCorners {
	public class ImageWithRoundedCorners : MonoBehaviour {
		private static readonly int Props = Shader.PropertyToID("_WidthHeightRadius");

		public float radius;
		private Material material;

		public Texture texture; // Nueva propiedad

		private RawImage image; // Cambiado de MaskableGraphic a RawImage

		private void OnValidate() {
			if (image is RawImage) { // Validar que image sea una instancia de RawImage
				Validate();
				Refresh();
			}
		}

		private void OnDestroy() {
			DestroyHelper.Destroy(material);
		}

		private void OnEnable() {
			Validate();
			Refresh();
		}

		private void OnRectTransformDimensionsChange() {
			if (enabled && material != null) {
				Refresh();
			}
		}

		public void Validate() {
			if (material == null) {
				material = new Material(Shader.Find("UI/RoundedCorners/RoundedCorners"));
			}

			if (image == null) {
				TryGetComponent(out image);
			}

			if (image != null) {
				image.material = material;
				image.texture = texture; // Asignar la textura en lugar del sprite
			}
		}

		public void Refresh() {
			var rect = ((RectTransform)transform).rect;
			material.SetVector(Props, new Vector4(rect.width, rect.height, radius, 0));
		}
	}
}
