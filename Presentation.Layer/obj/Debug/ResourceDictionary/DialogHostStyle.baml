   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aR NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   DialogHostTemplate  �� 
TargetType � RowDefinitions � ColumnDefinitions ��Name J� Opacity � UseLayoutRounding �� CornerRadius J� Effect3   -System.Windows.Media.Effects.DropShadowEffect    
BlurRadius	    Opacity
 ��Name � 	Resources  Key �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value*  $Microsoft.Xaml.Behaviors.Interaction   Triggers/  )Microsoft.Xaml.Behaviors.Core.DataTrigger   Value:  4Microsoft.Xaml.Behaviors.Core.PropertyChangedTrigger   Binding*  $Microsoft.Xaml.Behaviors.TriggerBase   Actions<  6Microsoft.Xaml.Behaviors.Media.ControlStoryboardAction  FadeInAnimation5  /Microsoft.Xaml.Behaviors.Media.StoryboardAction   
Storyboard  FadeOutAnimation?  9Microsoft.Xaml.Behaviors.Media.StoryboardCompletedTrigger6	  0Microsoft.Xaml.Behaviors.Media.StoryboardTrigger 	  
Storyboard8
  2Microsoft.Xaml.Behaviors.Core.ChangePropertyAction 
  PropertyName 
  Value4  .Microsoft.Xaml.Behaviors.TargetedTriggerAction   TargetObject�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     3i+http://schemas.microsoft.com/xaml/behaviors  5      :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %^  &	        7  7  7  �� 5      "  >�5      .R�5   
   �  5      �� 5	      $��* �6    �� 5
      $
��Auto �6    �� 5      $��* �6     5      �� 5      $��* �6#   �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5      �� $ BackgroundMask��6   ���#37474f$ .8Q�5   '   $��3��5      $��3��5      y�5      �� *DialogVisibility+5      �� 5      $��1��6   $��1��6%    . ���#37474f$ 10��6�   y�62   �� *DialogVisibility+ 5         5      $ 50Q�6'   $		 0.5Q�67   ._�5      �� $
 
DialogHost��6!   ��65   �� *DialogContent+y�6W   �� *DialogVisibility+5       5      ���� 5      FadeInAnimation .��5      U� $ (UIElement.Opacity)�64   $ 
DialogHost��5    4   .\�5!        $ 0��6/   $ 0Q�6;     5"      $ 0:0:0.08��6/   $	 0.7Q�6B     5#      $ 0:0:0.2��6/   $ 1Q�6A   5$      U� 5%      $ (UIElement.Opacity)�64   $ BackgroundMask��5&   4   .\�5'        $ 0��6/   $ 0Q�6;     5(      $ 0:0:0.15��6/   $	 0.5Q�6B   5)      5*      �� 5+      FadeOutAnimation .��5,      U� $ (UIElement.Opacity)�64   $ 
DialogHost��5-   4   .\�5.        $ 0��6/   $ 1Q�6;     5/      $ 0:0:0.1��6/   $ 0Q�6A   50      U� 51      $ (UIElement.Opacity)�64   $ BackgroundMask��52   4   .\�53        $ 0��6/   $	 0.5Q�6;     54      $ 0:0:0.1��6/   $ 0Q�6A   55      56      57       59        5:      $
 true��6;    6    �� *IsOpen+. 5;        8   60   5<        5=      $ false��6;    6    �� *IsOpen+. 5>        8  60   5?        5@      8  . 5A      
  $ DialogVisibility��6F   $ 	Collapsed��6f    6-   �� 6f   5B      5D      5E      5F      