   M S B A M L   `   `   `  ����M  IPresentation.Layer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Presentation.Layer.ControlPresentation.Layer.Control  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SFontAwesome5.Net, Version=2.1.4.0, Culture=neutral, PublicKeyToken=9cfaf01297a008f8R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   TextBox.Static.Border  �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border+    %Presentation.Layer.Control.matTextBox �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType � RowDefinitions ��Name ��Name �� CornerRadius	 J� SnapsToDevicePixels
 � ColumnDefinitions �� Triggers �� Binding �� RelativeSource �� Path �� UpdateSourceTrigger �� Mode �� Value ��Name   ScrollViewerControlTemplate1 ��Name  FontAwesome5.Awesome   Content  ButtonStyle1 �� AncestorType ��Name �� Padding �� TextAlignment  LabelStyle1 J� RenderTransformOrigin  ucTextBox_Foreground2 J� Opacity �� Triggers P� Property P� Value �� 
TargetName  ucTextBox_Highlight ]� 
Conditions  �� Property! �� Value" N� EnterActions# �� BeginStoryboardName$ ��Name% g� Duration& �� TargetProperty' �� 
TargetName( W� From	) W� To* N� ExitActions+ �Name, ��Name- ��Name. �� CanContentScroll/ �� CanHorizontallyScroll0 �� CanVerticallyScroll1 ��Name4  .System.Windows.Automation.AutomationProperties2   AutomationId3 � Cursor4 �� ScrollableHeight5 � Maximum6 � Minimum*7 �� #ComputedVerticalScrollBarVisibility8 �� ViewportHeight9 �� ViewportSize: � Value; �� ScrollableWidth< �� Orientation,= �� %ComputedHorizontalScrollBarVisibility> �� ViewportWidth  Button.Static.Background 	 Button.Static.Border 
 Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground? ��Name�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    1ctrl(clr-namespace:Presentation.Layer.Control  5      /fa5%http://schemas.fontawesome.com/icons/  5      :x,http://schemas.microsoft.com/winfx/2006/xaml     5      %"  &	        &	 #     &	 F     '   i     7   &	 �    &	 �    &		 �    &	
      &	 #    &	 F    &	 i    &	 �    &	 �    &	 �    &	 �    7 	 7  �� 5      $  	#FFABAdB3��65   �� 5      $  	#FF7EB4EA��68   �� 5      $  	#FF569DE5��64   �� 5	      "   6   .�5
   
   ��  � ��8   6(   �� 5   
    � ��
 �����6'   �� 5   
    � ��
 �   �6'   �� 5   
    � ��$ 1q�6,   �� 5   
    � ��$ 70��6#   �� 5   
    � ��$	 130��6%   �� 5   
    � ��$ 16(�6%   �� 5   
    � ��$	 5,0q�6$   �� 5   
    �@ TabNavigation$
 None=�6=   �� 5   
    � ��$
 Left=�67   �� 5   
    � ��$
 Left=�60   �� 5   
    � ��$ Center=�65   �� 5   
    �@�FocusVisualStyle 6-   Z� �� 5   
    �@J�	AllowDrop . 6&   �� 5   
    �@��PanningMode$ VerticalFirst=�65   �� 5   
    �@��IsFlicksEnabled .  63   �� 5   
    � �� 5      �� 5      "   6"   .R�5      �  5       �� 5!      $ R1��6,   $	��13* �68   �� 5"      $	��67* �6,   �� 5#      $	��20* �6,   .+�5&      �� $ border��6!   $��1��61   $ 5��6>   ���#e0e0e0$��2q�5'      #��z��6   	 .  ._�5(      � 
 5)   "   �� 5*   &   $��* �67   �� 5+   &   ��5,   *   �� 5-   .   " ��64   .�5.   2   ��  � ��$ 50 �6J    5/   2   �� 50   6    6B   ��  �� *TemplatedParent+$ HideClearButton�$ PropertyChanged=�$ TwoWay=� True6�   .a�51   :   ��  � ��$ 0 �6R   52   7   54   /   56   '   .+�58   "   �� $ PART_ContentHost��6/   $��0��6I   
������ |�.  $��Hidden=�6�   $��Hidden=�6�   #���  6�   �� 59   "   $ 	ClrButton��6)   ��.  $ Solid_TimesCircle=�5:   ~   |�.  $��18(�6�   
������ 
������ $D��>pack://application:,,,/FontAwesome5.WPF;component/#FontAwesome)�6�   $��1��6Q  #���  6a  ��59   N   �� $ IconCommand� �� "   5:   a  5;      5<      �� 5@      $ 	lblHeader��6$   $	 5,0q�67   $	��8,0q�6E   $��2��6T   $
��Auto��6e   $
��Auto��6r   ���	#99000000$ Center=�5A   $   $	��Top=�6;   #��z��6S   #��z��5C   $   #���  6g   $ 0.5,0.5&�6�   ��5B   $   ��  �� *TemplatedParent+$ 
TextHeader�$ PropertyChanged=�$ TwoWay=�z�5E      V� 5F   "   .~�5G   &   �� �� 5H   &   �� 5I   &   T� 5J   &   5K   #   5M      �� 5N      $ 	lblAssist��6$   $	 5,0q�67   $	��8,0q�6E   $��2��6R   
�������$
��Auto��6�   $
��Auto��6  #���  6  $��Center=�6J  #��z��6f  $��12(�6�  $ 0Q�6�  $y�	Collapsed=�6�  ��6r   ��  �� *TemplatedParent+$ AssistiveText�$ PropertyChanged=�$ TwoWay=�6�  5Q       5R      P� 5T       �@J�	IsFocused .  �5U      �� 5V   "   $ 	lblHeader��6?   # �  6W    � ���� 5W   "   # �  6@    � ���� 5X   "   $ border��6@    � �� �#326cf36U   5Z      ]� 5\       5]      �� 5^   "     �@J�	IsFocused! .  6A   �� 5_   "     � ��$!  ��6<   " 5b      �� 5c   "   $# 
sbFocusedT��63   �� 5d   "   $$ 
sbFocusedf��62   .��5e   &   �� .��5f   *   W� $% 0:0:0.1D�6:   $& (TextElement.FontSize)�6M   $' 	lblHeader��6�   $( 12X�6�   $) 16X�6�   5h   +   W� 5i   *   $% 0:0:0.1D�6:   $U& O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6M   $' 	lblHeader��6�   $) 24X�6�   5j   +   5k   '   5l   #   * 5n      �� 5p   "   $# 
sbFocusedf��63   �� 5r   "   $$ 
sbFocusedT��62   .��5s   &   �� .��5t   *   W� $% 0:0:0.1D�6:   $& (TextElement.FontSize)�6M   $' 	lblHeader��6�   $( 16X�6�   $) 12X�6�   5u   +   W� 5v   *   $% 0:0:0.1D�6:   $U& O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6M   $' 	lblHeader��6�   $) 0X�6�   5w   +   5x   '   5y   #   5{      P� 5}       � ��$  ��62   . �5~      �� $ 	ClrButton��6%    � y�$ 	Collapsed=�6R   5      P� 5�       �@��
IsReadOnly . . �5�      �� $ 	ClrButton��6%    � y�$ 	Collapsed=�6R   5�      P� 5�       � {� .  . �5�      ��  �@J�Opacity$
 0.50Q�68   5�      �� 5�      $
 true��6�    6&   ��  �� *TemplatedParent+$ 
IsNotValid�$ PropertyChanged=�$ TwoWay=�.a�5�      �� $ 	lblHeader��6%    � �� �#BF00006R   �� 5�      $ border��6%    � �� �#BF00006P   �� 5�       � �� �#BF00006;   5�      5�      5�      �� 5�   
    �@=�ErrorTemplate 5�      �� 5�      .R�5�      ]� ��. .+�5�      �� $��customAdorner��64   $��Center=�6I   5�      5�      5�      5�       5�   
   ]� 5�       5�      �� 5�      +  �@��#IsInactiveSelectionHighlightEnabled! . 6O   �� 5�        �@��IsSelectionActive! .  6=   ./�5�      ��  �@��SelectionBrush# � /�63   5�      5�      �� 5�      " ��6;   .R�5�   
   � $
+ Grid��6   #��z��6   
 5�      �� 5�      $��* �6#   �� 5�      $
��Auto �6#    5�      �� 5�      $��* �6    �� 5�      $
��Auto �6    .+�5�      �� $, Corner��6   $��1��6(   #��� ��68   $��1��6y   �� 5�      $!- PART_ScrollContentPresenter��6%   $��Center=�6J   #. z��6e   / .  0 .  #��z��6�   #��z��6	  $��0��6-  #��z��6=  $��0��6`  �� 5�      $1 PART_VerticalScrollBar��6   $2 VerticalScrollBar��68   $3 Arrow��6n   $��1��6}   #5 z4 6�   $6 0Q�6�   $��0��6�   #y�z7 6�   #9 z8 6u  : 6  �� *VerticalOffset+$ OneWay=� �� *TemplatedParent+6u  �� 5�      $1 PART_HorizontalScrollBar��6   $2 HorizontalScrollBar��6:   $3 Arrow��6r   $��0��6�   #5 z; 6�   $6 0Q�6�   $< 
Horizontal=�6�   $��1��6�   #y�z= 6�   #9 z> 6�  : 64  �� *HorizontalOffset+$ OneWay=� �� *TemplatedParent+6�  5�      5�      �� 5�      $  	#FFDDDDDD��68   �� 5�      $  	#FF707070��64   �� 5�      $  	#FFBEE6FD��6;   �� 5�      $  	#FF3C7FB1��67   �� 5�      $  	#FFC4E5F6��69   �� 5�      $  	#FF2C628B��65   �� 5�      $  	#FFF4F4F4��6:   �� 5�      $  	#FFADB2B5��66   �� 5�      $  	#FF838383��6:   �� 5�      " ��6!   .�5�   
   ��  �@�FocusVisualStyle 6-   Z� �� 5�   
    � ��8   6(   �� 5�   
    � ��$ 5q�6,   �� 5�   
    � �� �#326cf36'   �� 5�   
    � |� .  6&   �� 5�   
    � ��$ Center=�67   �� 5�   
    � ��$ Center=�65   �� 5�   
    � ��$ 1q�6$   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $ border��6   #��z��6-   $ 2��6Y   #��z��6j   #��z��6�   	 .  ._�5�      �� $? contentPresenter��6+   |�.  #��z��6W   #��z��6�   ��. #	 z	 6�   #��z��6  5�       5�      P� 5�       �@��IsDefaulted . 5�      P� 5�       �@J�IsMouseOver . 5�      P� 5�       � {� .  . �5�      �� $ border��68    �@J�Opacity$ 50Q�6L   �� 5�      $ contentPresenter��6G   8   � ��6e   5�      5�      5�      5�      5�      