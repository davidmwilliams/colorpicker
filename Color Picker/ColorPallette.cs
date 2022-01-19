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

		public ColorPallette() { }
	}
}
