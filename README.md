# Diamond Kata
---
### Problem/Requirements/Instructions

This kata is based on a post by Seb Rose here: http://claysnow.co.uk/recycling-tests-in-tdd/
Given a character from the alphabet, print a diamond of its output with that character being the midpoint of the diamond.

Examples

    > diamond.exe A
         A

    > diamond.exe B
           A
          B B
           A

    > diamond.exe C
            A
           B B
          C   C
           B B
            A
        
    > diamond.exe H
            A       
           B B      
          C   C     
         D     D    
        E       E   
       F         F  
      G           G 
     H             H
      G           G 
       F         F  
        E       E   
         D     D    
          C   C     
           B B      
            A       

It may be helpful visualise the whitespace in your rendering like this:

    > diamond.exe C
    _ _ A _ _
    _ B _ B _
    C _ _ _ C
    _ B _ B _
    _ _ A _ _


## Analysis/Discovery 
Before Coding and testing, I analyzed the problem and requirements and concluded the following things:

- External padding (in each side): number of chars - 1 at top. Reducing by 1 each line until middle then increase again until first. (number of rows - row index - 1)
- Internal padding: 0 at top then increasing by 2 until (number of chars * 2) - 3 at middle, then decrease again bt 2 until zero at first. (row index * 2) - 1
- Each char twice per line except A
- Bottom half and top half mirror each other - Process to draw them should be same but inverse
- Number of rows will be always odd
- If input char is not a letter, then it should just not render anything (give empty string)
- To not store all letters the function should determine the chars based on the input char. You can base the fact that you can get the int value of the char and work with that
- Based on the above should be also important to filter by uppercase letters only, maybe always applying uppercase or rejecting if not uppercase.

## Process

Based on above I think we need a method that Generate Diamond row by row. In each row we need to calculate and add how much external and internal padding we need. 
As bottom half is just mirror of top half we probably just need something that we can repeat in inverse order.
As number of rows is odd one of the half need to include the central row and the other does not.