   M S B A M L   `   `   `  ����I  EWp.WpfDemo.UIL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Wp.WpfDemo.UIL.ConvertersWp.WpfDemo.UIL.Converters  5	   	   U/clr-namespace:Wp.WpfDemo.UIL.ViewModels.Windows!Wp.WpfDemo.UIL.ViewModels.Windows  5
   	   K*clr-namespace:Wp.WpfDemo.UIL.Views.WindowsWp.WpfDemo.UIL.Views.Windows  5   	   -    'Wp.WpfDemo.UIL.Views.Windows.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   S OHandyControl, Version=3.1.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5   	   7	converter'clr-namespace:Wp.WpfDemo.UIL.Converters  5	   	   8vm/clr-namespace:Wp.WpfDemo.UIL.ViewModels.Windows  5
   	   6local*clr-namespace:Wp.WpfDemo.UIL.Views.Windows  5   	     � Title$  
MainWindow��5   	   $
��1080��5   	   $
��1920��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowState$ 	Maximized=�5   	      WindowStyle#���   5   	    � DataContext 5      4  .Wp.WpfDemo.UIL.ViewModels.Windows.MainWindowVM  5   
    J� InputBindings 5      �� 5   
    �� Gesture$ 
Ctrl+Alt+Q��6    �� Command 5      �� *KeyCmd+ � 	Resources 5       �� MergedDictionaries	 �� Source  DividerStyle
 �� 
TargetType#  HandyControl.Controls.Divider  DividerBaseStyle �� BasedOn �� Property �� Value " Primary500SolidColorBrushStyle5  /Wp.WpfDemo.UIL.Converters.FrameContentConverter  FrameContentConverter�� 5   
    5      �� 5      $7	 1/Styles/IconFontStyles/WindowTextBlockStyles.xaml?�6%   �� 5      $9	 3/Styles/DataTemplates/TreeViewItemDataTemplate.xaml?�6%   %�   &	       7  7  &	 �     �� 5       "
  5!      8   .�5#      ��  � ��$	 240��5$      �� 5%       � ��8  5&      �� 5'       � ��$ 20(�5(      �� 5)       � ��$ Center=�5*      5+        5,      6.   5-      .��5/      (�  (� Stretch$
 Fill=�6   .��50   
   )  #MaterialDesignThemes.Wpf.DrawerHost  $��Center=�6$   $��Center=�51   $   .��52      � .+�53      � $
��1080��6   $
��1920��54      .+�55      � $
��1080��6   $
��1920��56       � RowDefinitions 57      �� 58      $��64 �6,   �� 59      $��* �6,    � ColumnDefinitions 5;      �� 5<      $	��250 �6/   �� 5=      $��* �6/   .+�5?      � $��0��6   $��0��5@       " Primary700SolidColorBrushStyle#��[ 5A      .+�5B      �� $	��WPF��6(     SecondaryTextBlockStyle#��[ 5C   (   
�������5D   (   5E      � 5F      $��0��6   $��1��5G       " Primary600SolidColorBrushStyle#��[ 5H       5I      �� 5J   "   $��20 �63   �� 5K   "   $��* �63   �� 5L   "   $
��auto �63   �� 5M   "   $��10 �63   �� 5N   "   $��25 �63   �� 5O   "   $��25 �63   �� 5P   "   $��25 �63   �� 5Q   "   $��36 �63   .+�5S      �� $��1��6%    * &MaterialDesignFloatingActionMiniButton#��[ 5T   %   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=�5U   %   
�������
������� � ToolTip$ 弹出消息��5X   %   #��[ 5Y   %   $��26(�5Z   %   $��Right=�5[   %   ��5\   %   �� *	MsgBoxCmd+�� 5]      $��2��6%   #��[ 5^   %   $ Depth0=�5_   %   
�������
�������#��[ 5b   %   $��26(�5c   %      OpenDrawerCommand#��Z 5d   %   "  System.Windows.Controls.Dock   Left#��Z 5e   %   ��5f   %   �� *CurrentUserInfo.UserName[0]+ 5g   "   _� 5h   &   .��5i   *   �� �� 5j      �6   �� *CurrentUserInfo.UserName+ �� 5k      $�    已登录��6   6#   5l   '   5n      � 5o      $��4��6#   .+�5p   "   ��  	 PrimaryMinTextBlockStyle#��[	 6,   $ 	最小化��5q   ,   .  (System.Windows.Interactivity.Interaction   Triggers 5r      /  )System.Windows.Interactivity.EventTrigger  5s         	EventName$ MouseLeftButtonUp��6   .	  (System.Windows.Interactivity.TriggerBase 	  Actions. 5t      6
  0System.Windows.Interactivity.InvokeCommandAction
   
  Command 6   �� *MinCmd+ 
  CommandParameter 5u   0   ��  �� RelativeSource ��  �� AncestorType" �5v      5w       5x      � 5y      $��5��6#   .+�5z   "   ��  
 PrimaryMaxTextBlockStyle#��[
 6,   $ 向下还原��5{   ,    6<     5|      $ MouseLeftButtonUp��6   . 5}      
   6   �� *ReductionCmd+ 5~   0   ��  �� " �5      5�       5�      � 5�      $��6��6#   .+�5�   "   ��   PrimaryCloseTextBlockStyle#��[ 6,   $ 退出��5�   ,    5�        5�      $ MouseLeftButtonUp��6   . 5�      
   6   �� *
CloseCmd+ 5�   0   ��  �� " �5�      5�       5�      5�      � 5�      $��1��6   $��0��5�       ! Assist700SolidColorBrushStyle#��[ 5�      .+�5�      R� -   5         R�Name$ NavigationTree��5�   '   $��Stretch=�5�   '   $��Stretch=�5�   '   
������ $��18(�5�   '   
�������$��0q�5�   '   $��0q�5�   '    5�   '   ��  5�   "     5�   &   $ MouseLeftButtonUp��65   . 5�   *   
   6@   �� *NavigationItemClickCmd+ 5�   @   ��  ��  �� Mode$ FindAncestor=�" R� �� Path$ SelectedItem�5�   '   .@�5�   "   Q�   TreeViewItemStyle#��[ 5�   /     NavigationDataTemplate#���  5�   /    Q� 
IsSelected 5�   /   �� *IsHomeSelected+
  � Tag  5�   /   �� *NavigationItems[0]+5�   /   Q� 5�   "   #��[ 6/   #���  5�   /     5�   /   �� *NavigationItems[1]+5�   #   5�      5�      � 5�      $��1��6   $��1��5�      .+�5�       � $��Stretch=�5�   $   $��Stretch=�5�   $   !  � NavigationUIVisibility$! Hidden=�5�   $    ! Assist300SolidColorBrushStyle#��[ 5�   $   ��5�   $   �� " �� ElementName$" NavigationTree��$ SelectedItem�# �� 	Converter## [ 5�   b   5�      5�      �� 5�      $��	0 200 0 0q�6#   $��Hidden=�5�   #   $��Right=�5�   #   .��5�      �� !  HandyControl.Controls.Growl$   Token$	$ Msg��6'   $��Bottom=�5�   '   $��
0,10,10,10q�5�   '   5�      5�      �� 5�      $��	0 200 0 0q�6   $��Hidden=�5�      $��Right=�5�      .��5�      �� $	$ Msg��6#   $��Bottom=�5�   #   $��
0,10,10,10q�5�   #   5�      5�      %   LeftDrawerContent% 5�      � 5�      $��10q�6   $	��250��5�       5�      �� 5�      $
��auto �6(   �� 5�      $
��auto �6(   �� 5�      $��* �6(   .+�5�      �� $��0��6!   & �� Orientation$& Vertical=�5�   !   .+�5�        '   Content$' 当前登录用户��6%   #��[ 5�   %   �� 5�      $& 
Horizontal=�6%   $��
 20 0 20 0q�5�   %   .+�5�      d� $��Stretch=�6+   $��Stretch=�5�   +   $��50��5�   +   $��50��5�   +    ) %MaterialDesignActionLightToggleButton#��[ 5�   +    " Primary400SolidColorBrushStyle#��[ 5�   +   #��[ 5�   +   $��0q�5�   +   
�������$��25(�5�   +   ��5�   +   �� *CurrentUserInfo.UserName[0]+5�      �� 5�      $��8 0 0 0q�6)   $��1��5�   )   .+�5�   "   �� $
��Bold"�6,   $��20(�5�   ,   #��[ 5�   ,   ��5�   ,   �� *CurrentUserInfo.UserName+�� 5�   "   $��18(�5�   ,   #��[ 5�   ,   ( J� Opacity$
( 0.68Q�5�   ,   ��5�   ,   �� *CurrentUserInfo.Authority+5�   ,   5�      5�      5�      �� 5�      $��1��6!   $& Vertical=�5�   !   .+�5�        $' 当前系统时间��6%   #��[ 5�   %   (� 5�      $	��200��6"   $��70��5�   "   .��5�      %  HandyControl.Controls.FlipClock  #��[ 6+   5�      5�      5�      5�      5�      5�      