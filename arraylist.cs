//Create the arraylist object. It's a collection, not an array,
//so the syntax is slightly different
Arraylist dynamicList = new ArrayList();

//Add several things to the list.
//The arraylist is not strongly typed, so you can add any data type
//although it's simplest if you store just one type of object
//in any given collection.
dynamicList.Add("one");
dynamicList.Add("two");
dynamicList.Add("three");

//Retrieve the first string. Notice that the object must be converted to a string, 
//because there's no way for .NET to be certain of what it is.
string item=Convert.ToString(dynamicList[0]);
