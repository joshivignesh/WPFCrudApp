   M S B A M L   `   `   `  ����M  IPresentation.Layer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Presentation.LayerPresentation.Layer  5      +    %Presentation.Layer.CustomMessageBoxUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Presentation.Layer     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      $	��220��5      $	��500��6,      MaterialDesignBody#���   5      $��Regular"�5
   	   $��10(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	   .��5      � ���#fff � ColumnDefinitions 5   
   �� 5      $
��197* �6   �� 5      $
��295* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   #  MaterialDesignThemes.Wpf.Card  -   5          Name$ 
cardHeader��5      $��0��62   $��10q�6?   $��0q�6L   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth5=�6W    ! PrimaryHueDarkForegroundBrush#���  6�   $y�Visible=�6/  $��2��6D  ��6�   �� *
TitleColor+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� FallbackValue$ #00c853��.��5      �� .+�5      �� -   5        	 ��Name$	 txtTitle��5      $��Center=�6.   $��Stretch=�6K   $��20(�6h   ���#FFFF��6�   �� *Title+$ PropertyChanged=�$ TwoWay=�6�   5      5      �� 5   
   $��Right=�6   $��0,5,5,0q�62   $	��Top=�6D   $��1��6\   5!      � 5"   
   $��1��6   $��2��6   .+�5#      � $��20q�6    5$      �� 5%      $
��auto �6$   �� 5&      $
��auto �6$   �� 5'      $��* �6$   .+�5*      � $��0��6    5+      �� 5,      $
��auto �6(   �� 5-      $��* �6(   .+�50      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase
   OpeningEffects
 51      ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  52         Kind$ FadeIn=�6>     53      $ SlideInFromBottom=�6>   .��55      �� $��Center=�6~    �� 
IsReadOnly . $��0��6�   $��5q�6�   $��20(�6�   ��6"   �� *	Message+$ PropertyChanged=�$ TwoWay=�$
 Succ��6�   56      58      $� 59       $� Orientation$ 
Horizontal=�6)   $��Center=�6B   $��1��6_   $��0,45,0,5q�6l   .+�5;      �� $��50��6   $	��100��6*   $��Center=�67   ���#37474f
�������$��15(�5<   e   $��Ok��5=      $
��Left=�6*     btnButtonStyle#���  6E   $��Center=�6n    �� 	IsDefault . $
��20 0q�5>   h   {�5<      �� *	Savebtn+��5>   8   �� *	OkCommand+6h   5D      5F      5G      5H      5I      