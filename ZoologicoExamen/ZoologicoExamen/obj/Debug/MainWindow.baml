   M S B A M L   `   `   `  ����J  FZoologicoExamen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ZoologicoExamenZoologicoExamen  5   	        ZoologicoExamen.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ZoologicoExamen     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��Lista de Zoos��6   $
��Left=�6(   $��	46,30,0,0q�6C   $	��Top=�6V    J� RenderTransformOrigin$ 0.5,0.5&�6n   $��81��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.841Q�6&   T� 5      5      5      �� 5   
   $!��Lista de Animales Asociados��6   $
��Left=�66   $��
249,29,0,0q�6Q   $	��Top=�6e   $ 0.5,0.5&�6}   $	��161��6�   z�5      V� 5      .~�5      �� �� 5      �� 5      $ -0.841Q�6&   T� 5      5      5      �� 5   
   -   5         ��Name$ lbxListaZoos��5      $��31,62,631,217q�6(   6?   �� 5   
   -   5        $ lbxListaAnimales��5      $��262,62,400,217q�6,   �� 5    
   -   5        $ lbxListaAnimalesAgregar��5       $��541,62,121,125q�63   �� 5!   
   -   5         ��Name$ btnEliminarZoo��5!      $��Eliminar Zoo��6)   $
��Left=�6@   $��
42,240,0,0q�6[   $	��Top=�6o   $	��127��6�   �� 5"   
   -   5        $ btnQuitarAnimal��5"      $��Quitar Animal��6*   $
��Left=�6B   $��268,240,0,0q�6]   $	��Top=�6r   $	��126��6�   �� 5#   
   -   5        $ btnAgregarZoo��5#      $��Agregar Zoo��6(   $
��Left=�6>   $��
42,344,0,0q�6Y   $	��Top=�6m   $	��127��6�   �� 5$   
   -   5        $ btnAgregarAnimal��5$      $��Agregar Animal��6+   $
��Left=�6D   $��268,344,0,0q�6_   $	��Top=�6t   $	��127��6�   �� 5%   
   -   5        $ btnActualizarZoo��5%      $��Actualizar Zoo��6+   $
��Left=�6D   $��
42,382,0,0q�6_   $	��Top=�6s   $	��127��6�   �� 5&   
   -	   5        $ btnActualizarAnimal��5&      $��Acgtualizar Animal��6.   $
��Left=�6K   $��268,382,0,0q�6f   $	��Top=�6{   $	��127��6�   6�   �� 5'   
   -
   5        $ btnAgregarAnimalZoo��5'      $��Agregar Animal al Zoo��6.   $
��Left=�6N   $��
541,24,0,0q�6i   $	��Top=�6}   $	��127��6�   �� 5(   
   -   5        $ btnEliminarAnimal��5(      $��Eliminar Animal��6,   $
��Left=�6F   $��541,339,0,0q�6a   $	��Top=�6v   $	��127��6�   �� 5)   
   -   5         ��Name$ 
txtResumen��5)      $
��Left=�6&   $��
42,283,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $��TextBox��6i   $	��Top=�6x   $	��358��6�   $��26��6�   5+      5,      