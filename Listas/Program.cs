namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactList list = new ContactList();

            list.Add(new Contact("Bernardo", "123"));
            list.Add(new Contact("Ana", "321"));
            list.Add(new Contact("Caue", "456"));
            list.Add(new Contact("Bruna", "654"));
            list.Add(new Contact("Edenilson", "3214324"));
        }
    }
}
