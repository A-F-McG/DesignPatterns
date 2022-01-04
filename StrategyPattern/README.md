# Strategy Pattern

Say we have a bunch of creatures. We can create a chain of inheritance linking different creatures, so creatures down the chain inherit the same move and attack methods. We may end up in a situation where no matter how we arrange the vertical chain of inheritance, we need to duplicate code horizontally because different creatures share certain behaviours and differ in others.

The strategy pattern solves this issue. 
