# Diamond Kata
---
### Problem/Requirements/Instructions

This kata is based on a post by Seb Rose here: http://claysnow.co.uk/recycling-tests-in-tdd/
Given a character from the alphabet, print a diamond of its output with that character being the midpoint of the diamond.

Examples

    > diamond.exe
	> Enter your Character for the Diamond: A
         A

    > diamond.exe 
	> Enter your Character for the Diamond: B
           A
          B B
           A

    > diamond.exe 
	> Enter your Character for the Diamond: C
            A
           B B
          C   C
           B B
            A
        
    > diamond.exe 
	> Enter your Character for the Diamond: H
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

Based on above We need a method that Generate a Diamond row by row. In each row we need to calculate and add external and internal padding we need. 
As bottom half is just mirror of top half, We need something that we can repeat in inverse order.
As number of rows is odd, then one half need to include the central row and the other does not.

This should follow a TDD approach that you can see in commit history:
1. First step is to write test and code that just display A
2. Second step is to write test and code that generate a diamond of 2 letters A B
3. Third step is to generate a row for specific char with right external/internal padding. Generate Diamond A B using the generate row method.
4. Fourth step is to write test and code that generate a diamond of any size. This code may have some duplicated logic and not optimal
5. Fifth step is to Refactor the code, Remove duplications, optimize, etc
6. Sixth step is to do some edge cases: Not letter render empty string, lowercase letter render same as uppercase letter, check and test we can render Diamond 'Z' (biggest diamond), etc.

Notes: 
- In a real production project you would have a Core/BusinessLogic project separated from the command line UI and would have used Interfaces for the service and use DI but as this is small kata test dont think any of that is necessary.
- In a real production project may not have set GenerateRow as public but is public just for purpose of showing the TDD steps in detail.

