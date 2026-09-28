Console.WriteLine("Hello, Jerry");



A();
Thread.Sleep(500);
B();
Thread.Sleep(500);
C();


void A (){

    Console.WriteLine("A");
};

void B (){

    Console.WriteLine("B");
};

void C (){

    Console.WriteLine("C");
};

/*
A();
A();
void A()
{
    Console.WriteLine("A");
    {
        B();

        void B()
        {
            Console.WriteLine("B");
        }

        C();

        void C()
        {
            Console.WriteLine("C");
        }
    }
}
*/