class cse {
    int n1=34,n2=56,n3=55;
    public int cse1()
    {
    return n1;
    }
    public int cse2()
    {
        return n2;
    }
    public int cse3()
    {
        return n3;
    }
}
public class pro12{
    public static void main(String[] args)
    {
        cse cs=new cse();
        System.out.println(cs.cse1());

    }
}