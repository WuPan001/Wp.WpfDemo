   M S B A M L   `   `   `  ����I  EWp.WpfDemo.UIL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Wp.WpfDemo.UIL.Views.PagesWp.WpfDemo.UIL.Views.Pages  5      .    (Wp.WpfDemo.UIL.Views.Pages.ContactUsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      S OHandyControl, Version=3.1.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5      4local(clr-namespace:Wp.WpfDemo.UIL.Views.Pages  5        N� Title$  ContactUsPage��5	         MianWindowPageStyle#���   5       � 	Resources 5       �� MergedDictionaries �� Source  PrimarySolidColorBrushStyle  Green500ColorStyle �� Color  AssistSolidColorBrushStyle  Grey600ColorStyle  
ImageStyle �� 
TargetType �� Property �� Value  AnimationPathStyle)  #HandyControl.Controls.AnimationPath " Primary500SolidColorBrushStyle�� 5       5      �� 5      $3 -/Styles/GeometryStyles/LettersAndNumbers.xaml?�6   �� 5      $( "/Styles/SolidColorBrushStyles.xaml?�6   �� 5      $ /Styles/ColorStyles.xaml?�6   �� 5      $ /Styles/PageStyles.xaml?�6   �� 5      $ /Styles/BorderStyles.xaml?�6   %u  &	       7  &	      7  &	 8     &	 �     7  �� 5      8   5   	   �� 5      8   5   	   �� 5      " ��5      .�5      ��  � ��$
 1000��5      �� 5       � ��$	 600��5      �� 5        � ��$ UniformToFill=�5!      5"      �� 5#      "  5$      .�5%      ��  � ��$ Center=�5&      �� 5'       � ��$ 25��5(      �� 5)       � ��$ 25��5*      �� 5+       �@ Duration$ 00:00:05D�5,      �� 5-       �@��Stretch$ Uniform=�5.      �� 5/       � ��8   50      �� 51       � ��$ 1��52      53      54      .��56      � .+�57      ��   PageBorderStyle#��[ 6   ._�58      �  � RowDefinitions 59      �� 5:      $��20 �6   �� 5;      $��* �6   �� 5<      $	��150 �6   �� 5=      $��30 �6   �� 5>      $��30 �6   �� 5?      $��10 �6   .+�5A      � $��1��6   .+�5B      $  HandyControl.Controls.Carousel  	   IsCenter	 . 
   AutoRun
 . $
��1000��5D   
   $	��600��5E   
   $��Center=�5F   
   .  (HandyControl.Controls.SimpleItemsControl   Items. 5G      �� #��[ 6   $��/Resources/Naruto0.jpg��5H      �� 5I      #��[ 6   $��/Resources/Naruto1.jpg��5J      5K      5L      � 5M      $��2��6    � ColumnDefinitions 5N      �� 5O      $��20 �6   �� 5P      $��* �6   �� 5Q      $��* �6   �� 5R      $��* �6   �� 5S      $��20 �6   .+�5U      � $��1��6    5V      �� 5W   	   $��70 �6   �� 5X   	   $��* �6   .+�5]      ��  �� Orientation$ Vertical=�6   $��1��5^   
   $��Center=�5_   
   .+�5`   	   �� $��公司地址��6   #��[ 5a      $��20(�5b      $
��Left=�5c      $��Center=�5d      �� 5e   	   $
��Test��6   #��[ 5f      $��20(�5g      $
��Left=�5h      $��Center=�5i      5j   	   5k      � 5l      $��2��6    5m      �� 5n   	   $��70 �6   �� 5o   	   $��* �6   .+�5t      �� $ Vertical=�6   $��1��5u   
   $��Center=�5v   
   .+�5w   	   �� $��联系电话��6   #��[ 5x      $��20(�5y      $
��Left=�5z      $��Center=�5{      �� 5|   	   $
��Test��6   #��[ 5}      $��20(�5~      $
��Left=�5      $��Center=�5�      5�   	   5�      � 5�      $��3��6    5�      �� 5�   	   $��70 �6   �� 5�   	   $��* �6   .+�5�      �� $ Vertical=�6   $��1��5�   
   $��Center=�5�   
   .+�5�   	   �� $��电子邮箱��6   #��[ 5�      $��20(�5�      $
��Left=�5�      $��Center=�5�      �� 5�   	   $
��Test��6   #��[ 5�      $��20(�5�      $
��Left=�5�      $��Center=�5�      5�   	   5�      5�      � 5�      $��3��6    5�      �� 5�      $��* �6   �� 5�      $
��auto �6   �� 5�      $��20 �6   �� 5�      $
��auto �6   �� 5�      $��20 �6   �� 5�      $
��auto �6   �� 5�      $��* �6   .+�5�      �� $��1��6   $ 
Horizontal=�5�   	   $��Center=�5�   	   .+�5�         	 	DGeometry   Data# � 	 6   #��[ 5�        5�       
 	EGeometry# � 
 6   #��[ 5�        5�        	SGeometry# �  6   #��[ 5�        5�        	IGeometry# �  6   #��[ 5�        5�        	GGeometry# �  6   #��[ 5�        5�        	NGeometry# �  6   #��[ 5�      5�      �� 5�      $��3��6   $ 
Horizontal=�5�   	   $��Center=�5�   	   .+�5�          	BGeometry# �  6   #��[ 5�        5�        	YGeometry# �  6   #��[ 5�      5�      �� 5�      $��5��6   $ 
Horizontal=�5�   	   $��Center=�5�   	   .+�5�          	WGeometry# �  6   #��[ 5�        5�        	UGeometry# �  6   #��[ 5�        5�        	PGeometry# �  6   #��[ 5�        5�        	AGeometry# �  6   #��[ 5�        5�      # �  6   #��[ 5�      5�      5�      �� 5�      $��4��6   #��[ 5�   
   $��16(�5�   
   $��Center=�5�   
   $��Center=�5�   
   $��Copyright© 2020��5�   
   5�      5�      5�      5�      