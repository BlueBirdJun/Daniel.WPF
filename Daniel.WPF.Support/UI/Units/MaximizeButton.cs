using Jamesnet.Wpf.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Daniel.WPF.Support.UI.Units;

public class MaximizeButton : Button
{
	static MaximizeButton()
	{
		DefaultStyleKeyProperty.OverrideMetadata(typeof(MaximizeButton),
			  new FrameworkPropertyMetadata(typeof(MaximizeButton)));
	}

	public static readonly DependencyProperty IconChange =
				DependencyProperty.Register(
					 "ButtonIcon",                  // 속성 이름
					 typeof(string),            // 속성 타입
					 typeof(MaximizeButton),   // 소유 타입
					 new PropertyMetadata(      // 메타데이터
						  "Maximize",        // 기본값
						  OnMyTextChanged));     // 값 변경 콜백 함수

	// CLR 속성 래퍼
	public string ButtonIcon
	{
		get { return (string)GetValue(IconChange); }
		set { SetValue(IconChange, value); }
	}

	// 값 변경 시 호출되는 콜백 함수
	private static void OnMyTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		var control = d as MaximizeButton;
		if (control != null)
		{
			string newValue = (string)e.NewValue;
			Console.WriteLine(newValue);
			if ( control.Template!=null )
			{
				var jm = (JamesIcon)control.Template.FindName("iconname", control);
				if(newValue == "Apple")
					jm.Icon = IconType.Apple;
				else
					jm.Icon = IconType.Maximize;
			}
		
			//var textBlock = control.GetTemplateChild("Border") as Border;
			//if(textBlock !=null)
			//{
			//}
			//var jm= (JamesIcon)control.Template.FindName("iconname", control);

			//jm.Icon = IconType.Account;
			//Border border = GetTemplateChild("PART_Bar") as Border;



			// 여기서 속성 값이 변경되었을 때의 동작을 정의할 수 있습니다.
			//MessageBox.Show($"MyText changed to: {newValue}");
		}
	}
}
