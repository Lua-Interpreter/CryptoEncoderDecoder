   M S B A M L   `   `   `  ����O  KCryptoEncoderDecoder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CryptoEncoderDecoderCryptoEncoderDecoder  5   	   %    CryptoEncoderDecoder.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:CryptoEncoderDecoder     5   	     � Title$  
How to use��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $
��Left=�6   $��	37,10,0,0q�6/   $
��Wrap=�6B   $��
How to use��6V   $	��Top=�6h   $	��727��6�    �� TextAlignment$ Center=�6�   $��22��6�   $��20(�6�   �� 5   
   -   5         ��Name$ StartBTN��5      $��Try it out!��6#   $��Center=�69   $��311,378,301,10q�6V   $��Center=�6n   $	��180��6�   $��31��6�   6�   �� 5   
   $
��Left=�6   $��	37,37,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $	��454��6n   $	��151��6z   �� 6�   $_�YSelect an option from the dropdown menu, each option will have access to different menus.��6�   �� 6�   �� 6�   �� 6  �� 6  $&� Enter text into the input field.��6  �� 6;  �� 6G  �� 6M  �� 6Y  $J�DIf you selected Encryption then you will also need to fill in a key.��6]  �� 6�  �� 6�  �� 6�  �� 6�  $q�kThen press the button which depending on the dropdown selection could either say Encrypt or Hash or Decrypt��6�  �� 6B  6O  �� 5   
   $
��Left=�6   $��
37,193,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $	��736��6o   $	��180��6{   �� 6�   $�Hashing��6�   �� 6�   �� 6�   $���Hashing is a 1-way transform, meaning it cannot be reversed, therefore this cannot be decrypted or un-hashed, this is why it does not have a decrypt option.��6�   �� 6T  �� 6`  �� 6f  �� 6r  $�
Encryption��6v  �� 6�  �� 6�  $���This option can be encrypted and decrypted, however, to decrypt you need to use the same key you inputted as you encrypted the text originally with.��6�  �� 68  �� 6D  �� 6J  �� 6V  $�Keyless encryption��6Z  �� 6v  �� 6�  $x�rThis option can be encrypted and decrypted, however it does not require any key, due to the way its been designed.��6�  �� 6  �� 6  6  �� 5   
   
���   �$��1q�6%   $
��Left=�69   $	��151��6T   $��	30,37,0,0q�6a   $	��Top=�6t   $	��461��6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $	��180��6T   $��
30,193,0,0q�6a   $	��Top=�6u   $	��743��6�   �� 5   
   $
��Left=�6   $��47��6+   $��
496,23,0,0q�67   $	��Top=�6K   $��84��6c   $��
Image1.png��6n   �� 5   
   $
��Left=�6   $	��123��6+   $��
491,70,0,0q�68   $	��Top=�6L   $	��228��6d   $��
Image3.png��6p   5      5      