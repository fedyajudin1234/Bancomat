   M S B A M L   `   `   `  ����C  ?Bankomat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Bankomat.WindowsBankomat.Windows  5   	   %    Bankomat.Windows.RegisterWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Bankomat.Windows     5   	     � Title$  RegisterWindow��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   �� $��99,48,99,48q�6   
�������.+�5      �� -   5        $��Entrance_Text_Block��5      $��Welcome��64   $��18(�6C   $
��Bold"�6Q   $��Italic)�6c   $��Center=�6w   6�   �� 5      -   5         ��Name$ Login_Text_Block��5      $��Login: ��62   $��Italic)�6A   $��16(�6U   $
��Bold"�6c   $
��Wrap=�6u    J� RenderTransformOrigin$ -1.32,0.077&�6�   �� 5      -   5         ��Name$ Login_Text_Box��5       �� TextWrapping$
 Wrap=�6.   $��16(�6B   $
��Bold"�6P   $��Italic$�6b    �� TextAlignment$ Center=�6u   �� 5      -   5        $ Password_Text_Block��5      $��
Password: ��65   $��Italic)�6G   $��16(�6[   $
��Bold"�6i   $
��Wrap=�6{    �� TextAlignment$ Center=�6�   $
��Left=�6�   G� 5      -   5         G�Name$ Password_Text_Box��5      $��16(�65   $
��Bold"�6C   $��Italic$�6U   $��Center=�6h   �� 5      -   5        $! Confirm_Password_Text_Block��5      $��Conirm password: ��6=   $��Italic)�6V   $��16(�6j   $
��Bold"�6x   $
��Wrap=�6�   $ Center=�6�   $
��Left=�6�   G� 5      -   5        $ Confirm_Password_Text_Box��5      $��16(�6=   $
��Bold"�6K   $��Italic$�6]   $��Center=�6p   �� 5      -   5        $ Email_Text_Block��5      $��Email: ��62   $��Italic)�6A   $��16(�6U   $
��Bold"�6c   $
��Wrap=�6u   $ -1.32,0.077&�6�   �� 5      -	   5        $ Email_Text_Box��5      $
 Wrap=�6.   $��16(�6B   $
��Bold"�6P   $��Italic$�6b   $ Center=�6u   �� 5      -
   5        $ Score_Text_Block��5      $��Score name: ��62   $��Italic)�6F   $��16(�6Z   $
��Bold"�6h   $
��Wrap=�6z   $ -1.32,0.077&�6�   �� 5      -   5        $ Score_Text_Box��5      $
 Wrap=�6.   $��16(�6B   $
��Bold"�6P   $��Italic$�6b   $ Center=�6u   �� 5      -   5        $��Error_Text_Block��5      $��Error. Incorrect login��60   $��Italic)�6N   $��16(�6b   $
��Bold"�6p   $
��Wrap=�6�   $ Center=�6�   $y�Hidden=�6�   6�   �� 5      -   5         ��Name$ Register_Button��5      $��Register��6.   ���	#FFFFB3B3$��16(�6X   $
��Bold"�6f   $��Italic$�6x   $	��166��6�   6�   5      5      5      