   M S B A M L   `   `   `  ����M  IPresentation.Layer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Presentation.LayerPresentation.Layer  5   	   G(clr-namespace:Presentation.Layer.ControlPresentation.Layer.Control  5   
   #    Presentation.Layer.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Presentation.Layer     5   	   W SFontAwesome5.Net, Version=2.1.4.0, Culture=neutral, PublicKeyToken=9cfaf01297a008f8/fa5%http://schemas.fontawesome.com/icons/  5   	   3ctrl(clr-namespace:Presentation.Layer.Control  5   
     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�65    � WindowStyle$ ThreeDBorderWindow=�6K    � WindowState$ 	Maximized=�6l   .��5      � 
���   � � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $	��10* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ Backbdr��5   K   $��0��6   
�������$��1q�66   ���#F9F9F9$��0 0 0 2q�6s   ._�5      �  � ColumnDefinitions 5      �� 5      �� 5      $	��140 �6'   .+�5      +   %Presentation.Layer.Control.matTextBox  $��Right=�6%   $	��450��6A   $��80��6M   
�������   
TextHeader$ Search��6m   $��18(�5   /   $��	0 0 150 0q�6=   ��5   -   �� *Search+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�.��6v   5      $� 5      
 $� Orientation$
 Vertical=�6)   $��1��6@   $��Right=�6P   $��Center=�6l   .+�5!      ��  �� 	IsDefault . 
������   btnButtonStyle#���   6G   $��Apply��6�   $	��120��6�   $��45��6�   $
��Left=�6�   $��Center=�6�   $��5q�6�   ��6q   �� *FilterCommand+6�   �� 5#      ���#EF5454#���   63   $��2��6\   $��Reset��6i   $	��120��6�   $��45��6�   $
��Left=�6�   $��Center=�6�   $��5q�6�   ��6y   �� *ClearFilterCommand+6�   5&      5'      5(      �� 5)   
   $��1��6   
������� �� CornerRadius$ 2��61   $��1q�6B   ._�5*      $� $
 
Horizontal=�6%   .+�5+      �� ���#198B46#���   6.   $
��20 0q�6W   $��10,0,0,0q�6f   $	��Add��6x   $��Center=�5,   G   $	��100��5-   #   $��40��6/   $
��Left=�6<   $��Center=�5.   #   ��5,   #   �� *CreateCommand+5.   #   50      51      �� 52   
   $��2��6   
�������$ 5��61   $��1q�6B   ._�53      &   System.Windows.Controls.DataGrid  $��0q�6   $��1��6"   $��0q�60   ! �� IsDeferredScrollingEnabled .  %� VirtualizationMode$ 	Recycling=�55   F      SelectionMode$ Single=�6x   $   HorizontalScrollBarVisibility$ Disabled=�56         HeadersVisibility$ Column=�6@      AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .  "   VerticalScrollBarVisibility$
 Auto=�57      $	��550��6:      CanUserReorderColumns .     CanUserResizeRows .     CanUserSortColumns .     GridLinesVisibility$
 None=�6�      CanUserResizeColumns .  ��53   D   �� *Items+   Columns 58      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ Username��6)      
IsReadOnly .   HeaderLeftStyle2   HeaderStyle# [ 6N      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 5<   )     	CellStyle    	CellStyle#  [ 66   1  +System.Windows.Controls.DataGridBoundColumn!   Binding! 6]   �� *Name+$ TwoWay=�$	 PropertyChanged=�" �� FallbackValue$	" N/A��  5>      $ Email��6)    . # [ 6K   $ 2* 5?   )   #  [ 66   ! 6]   �� *Email+$	" N/A��  5A      $ Gender��6)    . # [ 6L   $	 100 5B   V     CellStyle-LeftCornerRadious#  [ 6c   ! 6)   �� *Gender+$	" N/A��6c     5D      $ Status��6)    .   HeaderCenterStyle# [ 6L   $	 200 5E   D     CenterCellStyle#  [ 6Q   ! 6)   �� *Status+6Q   4  .System.Windows.Controls.DataGridTemplateColumn  5I      #   
Visibility$# Visible=�6-   $	 100 6B   $
 Edit��6O     HeaderRightStyle# [ 6]     RightCellStyle#  [ 6�   $   CellTemplate$ 5J      �� 5K      .R�5L   "   �� ��6)   Z� ��6?   Z� ��5M   )   �� % �� RelativeSource% �� & �� AncestorType"&  ' �� Path$' DataContext.EditCommand���5N   )   �� .��5O   &     FontAwesome5.FontAwesome  (   Icon$( 
Solid_Edit=�66   $��30(�6H   ���#3074FD|�.  6k   5P   #   5Q      5S        5U      $	 100 6-   $ Remove��6:   # [ 6J   #  [ 6|   $ 5X      �� 5Y      .R�5Z   "   �� ��6*   Z� ��6@   Z� ��6W   �� % �� "&  $' DataContext.RemoveCommand���6�   �� .��5[   &     $( Solid_Trash=�66   $��30(�6I   
���  ��|�.  6h   5\   #   5]      5_      5b      5c      �� 5d   
   $��3��6   
�������$ 5��61   $��1q�6B   ._�5e      �� 
������ ��69   �� *
Pagination+$ TwoWay=�5f      >� 5g   
   -   5        ) >�Name$	) uc1��5g   ;   $��3��6   
�������  DialogHostTemplate#��[ 6H   * � DataContext* 5h      �� *
DialogHost+5i      5j      