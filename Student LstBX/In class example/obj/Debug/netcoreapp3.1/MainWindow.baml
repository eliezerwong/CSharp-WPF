   M S B A M L   `   `   `  ����K  GIn class example, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:In_class_exampleIn_class_example  5   	   !    In_class_example.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:In_class_example     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��106* �6   �� 5      $
��111* �6   .+�5   
   �� -   5         ��Name$ txtid��5      $
��Left=�6!   $��
106,57,0,0q�6<    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��120��6|   �� 5   
   $��SoonerID��6   $
��Left=�6#   $��	38,53,0,0q�6>   $	��Top=�6Q    J� RenderTransformOrigin$ 0.231,-0.204&�6i   �� 5   
   -   5        $ txtbxid_Copy1��5      $
��Left=�6)   $��
106,93,0,0q�6D   $��TextBox��6X   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   $��
First Name��6   $
��Left=�6%   $��	38,89,0,0q�6@   $	��Top=�6S   $ 0.231,-0.204&�6k   �� 5   
   -   5        $ txtFN��5      $
��Left=�6!   $��
106,93,0,0q�6<   $
 Wrap=�6P   $	��Top=�6d   $	��120��6|   �� 5   
   -   5        $ txtbxid_Copy3��5      $
��Left=�6)   $��106,136,0,0q�6D   $��TextBox��6Y   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   �� 5   
   $��	Last Name��6   $
��Left=�6$   $��
38,132,0,0q�6?   $	��Top=�6S   $ 0.231,-0.204&�6k   �� 5   
   -   5        $ txtLN��5      $
��Left=�6!   $��106,136,0,0q�6<   $
 Wrap=�6Q   $	��Top=�6e   $	��120��6}   �� 5   
   -   5        $ txtbxid_Copy7��5      $
��Left=�6)   $��	106,5,0,0q�6D   $��TextBox��6W   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   $��1��6�   �� 5   
   $	��GPA��6   $
��Left=�6   $��38,1,0,0q�69   $	��Top=�6K   $ 0.231,-0.204&�6c   $��1��6�   �� 5   
   -   5        $ txtGPA��5      $
��Left=�6"   $��	106,5,0,0q�6=   $
 Wrap=�6P   $	��Top=�6d   $	��120��6|   $��1��6�   �� 5   
   -   5        $ txtbxid_Copy9��5      $
��Left=�6)   $��
106,45,0,0q�6D   $��TextBox��6X   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   $��1��6�   �� 5   
   $��Bursar Balance��6   $
��Left=�6)   $��	38,41,0,0q�6D   $	��Top=�6W   $ 0.231,-0.204&�6o   $��1��6�   �� 5   
   -	   5        $ txtBB��5      $
��Left=�6!   $��
106,45,0,0q�6<   $
 Wrap=�6P   $	��Top=�6d   $	��120��6|   $��1��6�   �� 5   
   -
   5        $��Add Student��5      $
��Left=�6'   $��129,102,0,0q�6B   $	��Top=�6W    �� 	IsDefault$
 True��6o   $��1��6�   �� 5   
   -   5         ��Name$ Student��5      $��2��6#   $��	262,0,0,0q�64   6G   �� 5   
   -   5         ��Name$ chkProbation��5      $��Is student on Probation?��6)   $
��Left=�6L   $��
50,175,0,0q�6g   $	��Top=�6{   5       5!      