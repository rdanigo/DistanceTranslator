Class-Responsability-Collaborator Card

|----------------------------------------------------------|
|			  Program    			   |
|----------------------------------------------------------|
|			     |				   |
|			     |	DistanceConverter	   |
|			     |	TxtHandler		   |
| 			     |				   |
|			     |				   |
|----------------------------|-----------------------------|


|----------------------------------------------------------|
|			  TxtHandler			   |
|----------------------------------------------------------|
|			     |				   |
|In charge of Reading the    |	Null			   |
|Input Txt File and	     |	           		   |
|Writing the result on       |				   |
|the Output Txt File.	     |				   |
|			     |				   |
|----------------------------|-----------------------------|


|----------------------------------------------------------|
|			  DistanceConverter		   |
|----------------------------------------------------------|
|			     |				   |
|In charge of converting     |	Null			   |
|all the units of 	     |				   |
|distances that it gets      |				   |
|through the Txt File.	     |				   |
|			     |				   |
|----------------------------|-----------------------------|



UML Class Diagram

|----------------------------|
|	DistanceConverter    |
|--------------------------- |
|-Multiplier: int	     |
|-Counter: int		     |
|-Destiny: double	     |
|--------------------------- |
|+Convert(): void	     |
|----------------------------|
	||
	||
	||
	\/
|----------------------------|
|	   Program 	     |
|--------------------------- |
|-OriginDistance: string     |
|-DestinyDistance: string    |
|-parts: string[]            |
|-InputPath: string          |
|-OutputPath: string         |
|-Destiny: double            |
|-DistanceTypes: dictionary  |
|--------------------------- |
|+Formater(): void	     |
|+Converter(): void	     |
|----------------------------|
       	/\
       	||
	||
	||
|----------------------------|
|	TxtHandler	     |
|----------------------------|
|-InputPath: string	     |
|-OutputPath: string	     |
|----------------------------|
|+ReadTxt(): void	     |
|+WriteTxt(): void	     |
|----------------------------|
