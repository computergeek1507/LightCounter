using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LightCounter
{
	///<summary>
	// Processing Settings class
	///</summary>
	///
	[DefaultPropertyAttribute("AppSettings")]
	[Serializable]
	[XmlRoot("AppSettings")]
	public class AppSettings
	{
		//input settings

		//e131 settings
		private string m_ip_address = "192.168.1.102";
		private ushort m_universe = 1;
		private int m_start_channel = 1;
		private byte m_brightness = 127;
	
		[CategoryAttribute("E131 Settings"), DisplayName("E131 IP Address"), DescriptionAttribute("E131 IP Address of Controller")]
		public string IPAddress
		{
			get
			{
				return m_ip_address;
			}
			set
			{
				m_ip_address = value;
			}
		}

		[CategoryAttribute("E131 Settings"), DisplayName("Universe"), DescriptionAttribute("Start Universe")]
		public ushort Universe
		{
			get
			{
				return m_universe;
			}
			set
			{
				m_universe = value;
			}
		}

		[CategoryAttribute("E131 Settings"), DisplayName("Start Channel"), DescriptionAttribute("Start Cannel")]
		public int StartChannel
		{
			get
			{
				return m_start_channel;
			}
			set
			{
				m_start_channel = value;
			}
		}

		[CategoryAttribute("E131 Settings"), DisplayName("Brightness"), DescriptionAttribute("Light Output Brightness(0-255), start at 255, bright white, and adjust down if needed for a dim video")]
		public byte Brightness
		{
			get
			{
				return m_brightness;
			}
			set
			{
				m_brightness = value;
			}
		}	
	}
}
