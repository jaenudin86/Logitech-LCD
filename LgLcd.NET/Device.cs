﻿using System;
using System.Drawing;

namespace LgLcdNET
{
	// Represents a connection to all LCD devices
	// of a specific type attached to the system.
	public class Device
	{
		// The device handle
		public int Handle { get; private set; }

		// The type of the device
		public DeviceType Type { get; private set; }
		
		// The bitmap format the device supports
		public int BitmapWidth {
			get { return Type == DeviceType.Qvga ? (int)QvgaBmp.Width : (int)BwBmp.Width; }
		}
		public int BitmapHeight {
			get { return Type == DeviceType.Qvga ? (int)QvgaBmp.Height : (int)BwBmp.Height; }
		}
		public int BitmapBpp {
			get { return Type == DeviceType.Qvga ? (int)QvgaBmp.Bpp : (int)BwBmp.Bpp; }
		}

		public event EventHandler Left;
		public event EventHandler Right;
		public event EventHandler Ok;
		public event EventHandler Cancel;
		public event EventHandler Up;
		public event EventHandler Down;
		public event EventHandler Menu;

		public Device(DeviceType type) {
			Type = type;
		}

		public void Open(Applet applet) {
			OpenByTypeContext ctx = new OpenByTypeContext() {
				Connection = applet.Handle,
				DeviceType = Type,
				OnSoftbuttonsChanged = new SoftbuttonsChangedContext() {
					Context = IntPtr.Zero,
					OnSoftbuttonsChanged = new SoftButtonsDelegate(OnSoftButtons),
				}
			};
			ReturnValue error = LgLcd.OpenByType(ref ctx);
			if (error != ReturnValue.ErrorSuccess) {
				// TODO: Handle possible errors
				// ServiceNotActive (Init not called)
				// InvalidParameter (Invalid/closed handle/connection/applet or enum value)
				// AlreadyExists (DeviceType already opened)
				// Xxx
				throw new Exception();
			}
			Handle = ctx.Device;
		}

		public void UpdateBitmap(Bitmap bitmap, Priority priority) {
			if (bitmap.Width != BitmapWidth || bitmap.Height != BitmapHeight) {
				throw new ArgumentException("The bitmaps dimensions do not conform.");
			}
			LgBitmap lgBitmap = new LgBitmap() {
				Format = Type == DeviceType.Qvga ? BitmapFormat.QVGAx32 : BitmapFormat.Monochrome,
				Pixels = new byte[BitmapHeight * BitmapHeight * BitmapBpp],
			};
			for (int x = 0; x < BitmapWidth; x++) {
				for (int y = 0; x < BitmapHeight; y++) {
					Color pixel = bitmap.GetPixel(x, y);
					// TODO: Stuff the data into lgBitmap
					// Careful here, G15 has 1 byte per pixel while G19 has 4
					// Maybe this should be left up to derrived classes,
					// but then again I do not want two almost identical implementations,
					// it's just about converting the pixel into byte(s)
				}
			}
			LgLcd.UpdateBitmap(Handle, lgBitmap, priority);
		}

		public SoftButtonFlags ReadSoftButtons() {
			SoftButtonFlags buttonFlags;
			LgLcd.ReadSoftButtons(Handle, out buttonFlags);
			return buttonFlags;
		}

		public void SetAsLCDForegroundApp(bool yesNo) {
			LgLcd.SetAsLCDForegroundApp(Handle, yesNo);
		}

		public void Close() {
			LgLcd.Close(Handle);
		}

		private int OnSoftButtons(int device, SoftButtonFlags buttons, IntPtr context) {
			switch (buttons) {
				case SoftButtonFlags.Left:
					Left(this, null);
					break;
				case SoftButtonFlags.Right:
					Right(this, null);
					break;
				case SoftButtonFlags.Ok:
					Ok(this, null);
					break;
				case SoftButtonFlags.Cancel:
					Cancel(this, null);
					break;
				case SoftButtonFlags.Up:
					Up(this, null);
					break;
				case SoftButtonFlags.Down:
					Down(this, null);
					break;
				case SoftButtonFlags.Menu:
					Menu(this, null);
					break;
			}
			return 0;
		}
	}
}