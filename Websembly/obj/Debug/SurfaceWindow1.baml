   M S B A M L   `   `   `  ����  	Websembly(    "SurfaceApplication1.SurfaceWindow1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      e aMicrosoft.Surface.Presentation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e351s)http://schemas.microsoft.com/surface/2008  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  SurfaceApplication1��5      $	��800��5      $
��1200��5      
���   � � SizeToContent$ WidthAndHeight=�5      ��5      �� *WindowHeight+��5      �� *WindowWidth+ � 	Resources 5         Data � XPath 
 Source �� Source �� Source �� XPath �� GroupDescriptions2  ,System.Windows.Data.PropertyGroupDescription   PropertyName  ContainerItemTemplate  ImageOnlyTemplate  ImageAndCaptionTemplate  CursorStyle	 �� 
TargetType
 �� Property �� Value �� 
TargetType��%  &	        &	 �	    7   &	 
    &	 X
    &	 �
    &	 �    7  � 5   
   $ Photos��6'   .��5      ��<Photos xmlns="">
                    <Picture Path="C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\doggy.jpg" Category="Pictures" />
                    <Picture Path="C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\duck.jpg" Category="Pictures" />
                    <Picture Path="C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\kitties.jpg" Category="Pictures" />
                    <Picture Path="C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\elephant.jpg" Category="Pictures" />
                    <Picture Path="C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\otters.jpg" Category="Pictures" />
                    <Picture Path="C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\racoon.jpg" Category="Pictures" />
                    <Picture Path="C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\piggie.jpg" Category="Pictures" />
                    
                    <Picture Path="C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\icons\caption_R1L.jpg" Category="Text" />
                    <Picture Path="C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\icons\caption_R1C.jpg" Category="Text" />
                    <Picture Path="C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\icons\caption_R1R.jpg" Category="Text" />
                    <Picture Path="C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\icons\caption_R2L.jpg" Category="Text" />
                    <Picture Path="C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\icons\caption_R2C.jpg" Category="Text" />
                    <Picture Path="C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\icons\caption_R2R.jpg" Category="Text" />
                    <Picture Path="C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\icons\title.jpg" Category="Text" />

                    <Picture Path="C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\Videos\video1.jpg" Category="Video" />
                    <Picture Path="C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\Videos\video2.jpg" Category="Video" />
                    <Picture Path="C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\Videos\video3.jpg" Category="Video" />


                </Photos>        58      �� 5;   
    5=      �� 8   $ Picture�� 5>        5?      $ 	@Category��6+   5A      �� 5C   
   .R�5E      �� $	��200��63   ��6   �� $ @Path��63   5F      �� 5I   
   .R�5J      �� $	��200��6.   $	��150��6=   $��Center=�6J   $��Center=�6g   $��UniformToFill=�6�   ��6   �� *Source+6�   5K      �� 5M   
   .R�5N      �� .+�5O      �� $	��150��62   $�� ��6A   $��Uniform=�6O   ��6   �� *Source+6O   �� 5P      $	��150��65   $��WrapWithOverflow=�6D   $��Center=�6d   ��6   �� *	Caption+6d   5Q      5R      �� 5T   
   "	 ��6$   .�5U      �� 
 � ��8   60   �� 5V      
 � �� 5W      �� 5X      " ��6&   .R�5Y      �� #��z��5Z      #��z��5[      5\      5]      5_      5`      5b      .��5d      �  � ColumnDefinitions 5h   
   �� 5i      $
��592* �6   �� 5j      $
��586* �6   .+�5l   
   �� $��Arial)�6   $��Style Sheet��5m      $
��Left=�6*   $	��Top=�5n      $��18(�5o      
�������5p   )   � 5s   
    � ShowGridLines . 
���   �$��0,0,6,0q�67    � RowDefinitions 5t      �� 5u      $
��Auto �6    �� 5v      $
��Auto �6    �� 5w      $
��211* �6    .+�5y      �� $��Arial)�6   $��Style Sheet��5z      $��0��5{      $
��Left=�5|      $	��Top=�5}      $��18(�5~      
�������5   )   � 5�      -   5         �Name$ P_Grid��5�      
����ح�$
�� 396��5�      $	��386��5�      $��Right=�5�      $��25q�5�      .+�5�      �� ���	#FF48484A.+�5�      �� $��5q�6   
���   �$��Arial)�6:   $��22(�6M   $��Center=�6[   $��Center=�6x   $��Center=�6�   $��Center=�6�   $	��305��6�   .��6�   Style Sheet 16�   �� 5�      $��46��6   .+�5�      �� -   5        $��P_Cover_Label��5�       $	��375��65   $��46��6A    �� Left$ 3��6M   
 �� Top$ -8��6]   }�.   J� 	AllowDrop . ��5�      �� 5�   "    �� ImageSource$c ]file:///C:/Users/balichmac1/Desktop/Websembly%20Demo%20ReVamp/Resources/Icons/Icons_Title.jpg��6-   5�      5�      �� 5�       �� Orientation$ 
Horizontal=�6!   .+�5�      �� .+�5�      �� -   5         ��Name$ P_R1L_Label��5�   $   
������ $ 8��6S   $ 0��6c   }�.  . $	��120��6%  $��91��61  ��5�   "   �� 5�   &   $h bfile:///C:/Users/balichmac1/Desktop/Websembly%20Demo%20ReVamp/Resources/Icons/icon_P_R1L_Label.jpg��61   5�      5�      �� 5�      5�      �� 5�      .+�5�      �� -   5        $ P_R1R_Label��5�   $   $	 258��69   $ 0��6K   }�.  . $	��120��6  $��90��6  ��5�   "   �� 5�   &   $h bfile:///C:/Users/balichmac1/Desktop/Websembly%20Demo%20ReVamp/Resources/Icons/icon_P_R1R_Label.jpg��61   5�      5�      5�      �� 5�      $ 
Horizontal=�6!   .+�5�      �� $��40��6!   $	��120��60   $ 8��6?   $ 97��6O   .+�5�      �� -   5        $ 
CR1L_Label��5�   $   $ 8��68   $ 97��6H   }�.  . $	��120��6  $��40��6  ��5�   "   �� 5�   &   $b \file:///C:/Users/balichmac1/Desktop/Websembly%20Demo%20ReVamp/Resources/Icons/CR1L_Label.jpg��61   5     5     �� 5     $��40��6!   $	��120��60   $	 133��6?   $ 97��6Q   .+�5     �� -   5        $ 
CR1C_Label��5  $   $	 133��68   $ 97��6J   }�.  . $	��120��6  $��40��6   ��5  "   �� 5  &   $b \file:///C:/Users/balichmac1/Desktop/Websembly%20Demo%20ReVamp/Resources/Icons/CR1C_Label.jpg��61   5
     5     �� 5     $��40��6!   $	��120��60   $	 258��6?   $ 97��6Q   .+�5     �� -   5        $ 
CR1R_Label��5  $   $	 258��68   $ 97��6J   }�.  . $	��120��6  $��40��6   ��5  "   �� 5  &   $b \file:///C:/Users/balichmac1/Desktop/Websembly%20Demo%20ReVamp/Resources/Icons/CR1R_Label.jpg��61   5     5     5     �� 5     $ 
Horizontal=�6!   .+�5     �� .+�5(     �� -   5        $ P_R2L_Label��5(  $   $ 8��69   $	 147��6I   }�.  . $	��120��6  $��90��6  ��5)  "   �� 5*  &   $h bfile:///C:/Users/balichmac1/Desktop/Websembly%20Demo%20ReVamp/Resources/Icons/icon_P_R2L_Label.jpg��61   5,     5.     �� 50     .+�59     �� -	   5        $ P_R2C_Label��59  $   $	 133��69   $	 147��6K   }�.  . $	��120��6  $��90��6  ��5:  "   �� 5;  &   $h bfile:///C:/Users/balichmac1/Desktop/Websembly%20Demo%20ReVamp/Resources/Icons/icon_P_R2C_Label.jpg��61   5=     5?     �� 5A     .+�5J     �� -
   5        $ P_R2R_Label��5J  $   $	 258��69   $	 147��6K   }�.  . $	��120��6  $��90��6  ��5K  "   �� 5L  &   $h bfile:///C:/Users/balichmac1/Desktop/Websembly%20Demo%20ReVamp/Resources/Icons/icon_P_R2R_Label.jpg��61   5N     5P     5Q     �� 5T     $ 
Horizontal=�6!   .+�5U     �� $��40��6!   $	��120��60   $ 8��6?   $	 242��6O   .+�5V     �� -   5        $ 
CR2L_Label��5V  $   $ 8��68   $	 242��6H   }�.  . $	��120��6  $��40��6  ��5Z  "   �� 5[  &   $b \file:///C:/Users/balichmac1/Desktop/Websembly%20Demo%20ReVamp/Resources/Icons/CR2L_Label.jpg��61   5]     5_     �� 5a     $��40��6!   $	��120��60   $	 133��6?   $	 242��6Q   .+�5b     �� -   5        $ 
CR2C_Label��5b  $   $	 133��68   $	 242��6J   }�.  . $	��120��6  $��40��6!  ��5f  "   �� 5g  &   $b \file:///C:/Users/balichmac1/Desktop/Websembly%20Demo%20ReVamp/Resources/Icons/CR2C_Label.jpg��61   5i     5k     �� 5m     $��40��6!   $	��120��60   $	 258��6?   $	 242��6Q   .+�5n     �� -   5        $ 
CR2R_Label��5n  $   $	 258��68   $	 242��6J   }�.  . $	��120��6  $��40��6!  ��5r  "   �� 5s  &   $b \file:///C:/Users/balichmac1/Desktop/Websembly%20Demo%20ReVamp/Resources/Icons/CR2R_Label.jpg��61   5u     5w     5x     �� 5y     -   5        $ P_R1C_Label��5y     
������ $	 258��6K   $ 3��6]   }�.  . $	��120��6  $��90��6+  ��5z     �� 5{     $h bfile:///C:/Users/balichmac1/Desktop/Websembly%20Demo%20ReVamp/Resources/Icons/icon_P_R1C_Label.jpg��6)   5}     5�     5�     >  8Microsoft.Surface.Presentation.Controls.LibraryContainer  5�     -   5          Name$ LibraryContainer��5�  D   $��93,16,115,18q�6!   $��2��67      ItemsSource 6^   �� # [    	StackView 5�     7  1Microsoft.Surface.Presentation.Controls.StackView  5�     =  7Microsoft.Surface.Presentation.Controls.LibraryViewBase   ItemTemplate# [ 6!      BarView 5�     5  /Microsoft.Surface.Presentation.Controls.BarView  5�     # [ 6    5�     5�     �� 5�  
   $��Right=�6   $��Stretch=�5�      �� ResizeBehavior$ PreviousAndNext=�63   $��5��5�     ���	#FFBCBCBC6!   �� 5�  
   $��Right=�6   $��1��63   $	��574��6C   $��	0,0,12,78q�6O   .��5�     �� $��Arial)�6   $��Generated Code��5�     $��1��5�     $
��Left=�5�     $	��Top=�5�     $��18(�5�     
�������5�  )   5�     �� 5�  
   -   5        $��generatedCode��5�     $��1��5�     $��Courier New)�5�     $
��Left=�5�     $	��Top=�5�     $��18(�5�     
�������5�     �� 5�  
    �� ResizeDirection$ Columns=�6   $��0,0,6,0q�61   5�     5T     