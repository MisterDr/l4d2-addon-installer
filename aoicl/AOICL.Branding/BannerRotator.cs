using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace AOICL.Branding
{
	[Serializable]
	public class BannerRotator
	{
		public delegate void OnNextImageEventHandler();

		public delegate void SetPictureBoxImage(ref PictureBox PictureBox, ref Stream ImageData);

		[XmlIgnore]
		private BannerRotation _RotateOrder;

		[XmlElement("Banners", typeof(List<Banner>))]
		public List<Banner> _Banners;

		[XmlIgnore]
		[AccessedThroughProperty("_Timer")]
		private System.Timers.Timer __Timer;

		[XmlIgnore]
		public int bannerindex;

		[XmlIgnore]
		public PictureBox picturebox;

		private OnNextImageEventHandler OnNextImageEvent;

		[SpecialName]
		private Random _0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen;

		[SpecialName]
		private StaticLocalInitFlag _0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init;

		public virtual System.Timers.Timer _Timer
		{
			[DebuggerNonUserCode]
			get
			{
				return __Timer;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				ElapsedEventHandler value2 = _Timer_Elapsed;
				if (__Timer != null)
				{
					__Timer.Elapsed -= value2;
				}
				__Timer = value;
				if (__Timer != null)
				{
					__Timer.Elapsed += value2;
				}
			}
		}

		[XmlIgnore]
		public BannerRotation Rotation
		{
			get
			{
				return _RotateOrder;
			}
			set
			{
				_RotateOrder = value;
			}
		}

		public event OnNextImageEventHandler OnNextImage
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				OnNextImageEvent = (OnNextImageEventHandler)Delegate.Combine(OnNextImageEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				OnNextImageEvent = (OnNextImageEventHandler)Delegate.Remove(OnNextImageEvent, value);
			}
		}

		public BannerRotator()
		{
			_RotateOrder = BannerRotation.Random;
			_Banners = new List<Banner>();
			_Timer = new System.Timers.Timer();
			bannerindex = -1;
			_0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init = new StaticLocalInitFlag();
		}

		public int RandomNumber(int low, int high)
		{
			Monitor.Enter(_0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init);
			try
			{
				if (_0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init.State == 0)
				{
					_0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init.State = 2;
					_0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen = new Random();
				}
				else if (_0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				_0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init.State = 1;
				Monitor.Exit(_0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init);
			}
			return _0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen.Next(low, checked(high + 1));
		}

		public void Start()
		{
			NextImage();
		}

		public void Stop()
		{
			_Timer.Enabled = false;
			_Timer = null;
		}

		public void NextImage()
		{
			checked
			{
				try
				{
					if (Rotation == BannerRotation.InOrder)
					{
						bannerindex++;
						if (bannerindex > _Banners.Count - 1)
						{
							bannerindex = 0;
						}
					}
					else if (Rotation == BannerRotation.Random)
					{
						bannerindex = RandomNumber(0, _Banners.Count - 1);
					}
					_Timer.Interval = _Banners[bannerindex]._TimeOut * 1000;
					_Timer.Enabled = true;
					if (_Banners[bannerindex].ImageStream != null)
					{
						Banner banner = _Banners[bannerindex];
						Stream imageStream = banner.ImageStream;
					}
					OnNextImageEvent?.Invoke();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		private void _Timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			NextImage();
		}
	}
}
