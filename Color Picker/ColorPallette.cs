using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Color_Picker
{
    public class ColorPallette
    {
		[DataMember]
		public System.Drawing.Color Color { get; set; }

		[DataMember]
		public int DefaultWindowWidth { get; set; }

		private int colorPanelWidth;

		[DataMember]
		public int ColorPanelWidth
        {
			get
			{
				return this.colorPanelWidth;
			}
			set
			{
				colorPanelWidth = value | 10;
			}
        }

		public ColorPallette() { }
	}
}
