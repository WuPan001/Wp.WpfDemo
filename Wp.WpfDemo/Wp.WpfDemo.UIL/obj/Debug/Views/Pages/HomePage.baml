   M S B A M L   `   `   `  ����I  EWp.WpfDemo.BLL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]?clr-namespace:Wp.WpfDemo.BLL.Converters;assembly=Wp.WpfDemo.BLLWp.WpfDemo.BLL.Converters  5      I EWp.WpfDemo.UIL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Wp.WpfDemo.UIL.ViewModels.PagesWp.WpfDemo.UIL.ViewModels.Pages 5      U/clr-namespace:Wp.WpfDemo.UIL.Views.UserControls!Wp.WpfDemo.UIL.Views.UserControls 5	      N JWp.WpfDemo.WpThemes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:Wp.WpfDemo.WpThemes;assembly=Wp.WpfDemo.WpThemesWp.WpfDemo.WpThemes 5      )   #Wp.WpfDemo.UIL.Views.Pages.HomePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      `radioButtonConverter?clr-namespace:Wp.WpfDemo.BLL.Converters;assembly=Wp.WpfDemo.BLL     5      <vm-clr-namespace:Wp.WpfDemo.UIL.ViewModels.Pages     5      >uc/clr-namespace:Wp.WpfDemo.UIL.Views.UserControls     5	      S OHandyControl, Version=3.1.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5
      Hwpc>clr-namespace:Wp.WpfDemo.WpThemes;assembly=Wp.WpfDemo.WpThemes  5        N� Title$  HomePage��5         MianWindowPageStyle#���   5       � DataContext 5      0  *Wp.WpfDemo.UIL.ViewModels.Pages.HomePageVM  5   
    � 	Resources 5       �� MergedDictionaries �� Source4   .Wp.WpfDemo.BLL.Converters.RadioButtonConverter  radioButtonConverter�� 5   
    5      �� 5      $3 -/Styles/GeometryStyles/LettersAndNumbers.xaml?�6%   �� 5      $( "/Styles/SolidColorBrushStyles.xaml?�6%   �� 5      $ /Styles/ColorStyles.xaml?�6%   �� 5      $ /Styles/PageStyles.xaml?�6%   �� 5      $ /Styles/BorderStyles.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.PopupBox.xaml?�6%   %   &	         5      68   5      .��5!      ��   PageBorderStyle#��[ 6   ._�5"   
   &   HandyControl.Controls.TabControl     IsAnimationEnabled .    IsDraggable .    IsTabFillEnabled . $��20q�5%      .@�5&      #  HandyControl.Controls.TabItem  $��TabItem7��6    �� 
IsSelected . $��30��5(      $��	0,0,0,0.4q�5)      $��Bottom=�5*      .��5+      � 
�������	 � ColumnDefinitions	 5,      �� 5-      �� 5.      �� 5/      
 � RowDefinitions
 51      �� 52      �� 53      �� 54      �� 55      �� 56      .+�58      �� $��10q�6!     TabControlInLine#��[ 59   !   .@�5:      �� $��
选项卡1��6"   62   �� 5;      $��
选项卡2��6"   62   �� 5<      $��
选项卡3��6"   62   5=      #  MaterialDesignThemes.Wpf.Card  5>      $��0��6*   $��1��5?   *   $��10q�5@   *      UniformCornerRadius$ 3Q�5A   *     MaterialDesignBackground#���  5B   *   .��5C      9� $��Stretch=�6#   
�������
��� � � 9� 
IsExpanded .  
���������5H      �� 5I   "    �� Orientation$ 
Horizontal=�6-   .+�5J   &   �� $��/Resources/Naruto0.jpg��6,   $��20��5K   ,   $��20��5L   ,    J� Clip 5M   *   @� 5N   .    @� RadiusX$ 10Q�6>    @� RadiusY$ 10Q�5O   >    @� Center$
 10,6&�5P   >   5R   '   �� 5S   &   $	��123��60   $��Center=�5T   0   �� 5U   &   $
��2323��60   $��Center=�5V   0   5W   #   .��5Y      �� $ Vertical=�6)     MaterialDesignBody#���  5Z   )   $��
24,8,24,16q�5[   )   .+�5\   "   �� $��Your Content��6,   �� 5]   "    J� Opacity$	 .68Q�6,   $����Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.��5^   ,   $
��Wrap=�5_   ,   5`      5a      5b      �� 5c      $��2��6!   $��0��5d   !   $ Vertical=�5e   !   $��Center=�5f   !   $��Center=�5g   !   .+�5h      �� -   5         ��Name$ 
TestRender��5i   $   $��旋转��5h   $    � Cursor$
 Hand��5j   $   $��20(�5k   $   $��Center=�5l   $    J� RenderTransformOrigin$ 0.5,0.5&�5m   $   z�5n      �� 5o   "    �� Angle$ 0Q�62    � Triggers 5q      :� 5r   "    :� RoutedEvent$ 
MouseEnter��6/   .[�5s   &   �� .��5t   *   �� .��5u   .   U�  �� 
TargetName$ 
TestRender��6M    �� TargetProperty$ RenderTransform.Angle�5v   M   .\�5w   2   ��  O� Value$ 0Q�6G    O� KeyTime$ 0:0:0��5x   G   �� 5y   2   $	 180Q�6G   $ 0:0:0.5��5z   G   �� 5{   2   $	 360Q�6G   $ 0:0:1��5|   G   5}   /   5~   +   5   '   5�   #   5�   4   �� 5�      -   5        $ TestOpacity��5�   $   $��消失��5�   $   $
 Hand��5�   $   $��20(�5�   $   $��Center=�5�   $    5�      :� 5�   "   $ 
MouseEnter��6/   .[�5�   &   �� .��5�   *   �� .��5�   .   W� $ TestOpacity��6>   $ Opacity�5�   >    W� From$ 1X�5�   >   	 W� To$	 0.2X�5�   >    g� Duration$ 0:0:1D�5�   >   6Q   5�   +   5�   '   5�   #   :� 5�   "   $ 
MouseLeave��6/   .[�5�   &   �� .��5�   *   �� .��5�   .   W� $ TestOpacity��6>   $ Opacity�5�   >   $ 1X�5�   >   $ 1X�5�   >   $ 0:0:00.1D�5�   >   6T   5�   +   5�   '   5�   #   5�   4   5�      �� 5�      $��/Resources/Naruto0.jpg��6   $��1��5�      $��0��5�      $
��auto��5�      $
��auto��5�       5�      @� 5�      $ 50Q�6.   $ 50Q�5�   .   $ 100,90&�5�   .   5�      �� 5�      $��1��6!   $��1��5�   !   $��Center=�5�   !   
�������.+�5�      	� $��参数1��5�   &     d� 	IsChecked  5�   &   �� *TestRadioButton+! �� Mode$! TwoWay=�" �� 	Converter#" [ # �� ConverterParameter$# 0��5�   &   	� 5�      $��参数2��5�   &     5�   &   �� *TestRadioButton+$! TwoWay=�#" [ $# 1��5�   &   	� 5�      $��参数3��5�   &     5�   &   �� *TestRadioButton+$! TwoWay=�#" [ $# 2��5�   &   	� 5�      $��参数4��5�   &     5�   &   �� *TestRadioButton+$! TwoWay=�#" [ $# 3��5�   &   �� 5�      ��6!   �� *TestRadioButtonCmd+.��6H   test6N   5�      �� 5�      $��2��6!   $��1��5�   !   $ Vertical=�5�   !   
�������.+�5�      � -   5        $ �Name$$ 	ChipPanel��5�   $   $
��auto��5�   $   $	��300��5�   $   .+�5�      #  MaterialDesignThemes.Wpf.Chip  $��James Willock��62   %   IsDeletable% . 
�������
���   �$��3q�5�   2   &   IconBackground
& �  ��' � ToolTip$' Just a tool tip��5�   2   (   DeleteToolTip$+( %Your friendly neighbour delete button��5�   2   )   DeleteCommand) 5�   2   �� *DeleteChipCmd+*   DeleteCommandParameter* 5�   2   �� + �� RelativeSource+ �� , �� Mode$
, Self=�-   Icon- 5�   "   �� 5�   &   $��/Resources/Naruto0.jpg��6,   5�        5�      $��James Willock1212��62   % . 
�������
���   �$��3q�5�   2   
& �  ��$' Just a tool tip��5�   2   $+( %Your friendly neighbour delete button��5�   2   ) 5�   2   �� *TestDeleteChipCmd+* 5�   2   �� + �� $
, Self=�- 5�   "   �� 5�   &   $��/Resources/Naruto0.jpg��6,   6N   5�      5      �� 5     ��6!   �� *
AddChipCmd+��5  !   �� . �� ElementName$. 	ChipPanel��.��6T   
添加Chip6\   5     '  !MaterialDesignThemes.Wpf.PopupBox  5     $��0��6.   $��2��5  .    - )MaterialDesignMultiFloatingActionPopupBox#��[ 5  .   $��Right=�5  .   $��Bottom=�5  .   /   PopupContent./ 5	     �� .+�5
     �� $' GitHub��6%   ��5  %   0  *MaterialDesignThemes.Wpf.PackIconExtension  0   Kind$0 Github=�1   Size$1 20X��� 5     $' Twitter��6%     PrimaryHueMidBrush#���  5  %      PrimaryHueMidForegroundBrush#���  5  %   ��5  %     $0 Twitter=�$1 20X�5     5     � 5     $��2��6   $��1��5     
 5     �� 5     $��3* �6,   �� 5     $��* �6,   .+�5     � -   5        2 �Name$2 TestPrinter��5     $��0��5     .+�5     �� $��TestPrinter��6(   $��70(�5  (   5     �� 5     -   5        $��1��5  !   
����ح�$��打印��5  !   $��26(�5   !   $
��auto��5!  !   5"  !   5#     (	  "Wp.WpfDemo.WpThemes.CustomControl1	  5$     $��2��6)   $��2��5%  )   3 	  	TestColor$	3 Red��5&  )   5'     5(       5)     $��滚动数字��6   .��5*     5
  /Wp.WpfDemo.UIL.Views.UserControls.RollingNumber
  6%   5+     5,     5-     5.     