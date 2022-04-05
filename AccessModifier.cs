//internal For Interclass
//public for outside 
// private for in class only


internal class AccessModifier
{
    internal void DoSomething()
    {

    }

    public void DoAnotherThing()
    {
        DoSomething();
    }
}

class ModifierDemo
{
    void DoSomething()
    {
    AccessModifier accessModifier=new AccessModifier();
    accessModifier.DoSomething();
    Person person=new Person();
    person.name="Ritesh";
    
    person.Age=41; //will not be assigned because of value condition in properties
    }

}