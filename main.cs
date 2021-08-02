using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
  public ListNode FindIntersection(ListNode head){
    if(head==null){
      return null;
    }
    ListNode fast=head;
    ListNode slow=head;
    while(slow!=null && fast!=null && fast.next!=null){
      slow=slow.next;
      fast=fast.next.next;
      if(slow==fast){
        break;
      }
    }
    if(fast==null|| fast.next==null){
      return null;
    }
    slow=head;
    while(slow!=fast){
      slow=slow.next;
      fast=fast.next;
    }
    return fast;
  }

  public ListNode FindIntersectionII(ListNode A, ListNode B){
    if(A==null|| B==null){
      return null;
    }
    ListNode tempA=A;
    ListNode tempB=B;
    int Asize=ListLength(tempA);
    int Bsize=ListLength(tempB);

    int diff=Math.Abs(Asize-Bsize);
    if(Asize>Bsize){
      for(int i=0; i<diff; i++){
        tempA=tempA.next;
        }
    }else{
      tempB=tempB.next;
    }

    while(tempA!=tempB){
      tempA=tempA.next;
      tempB=tempB.next;
    }
    return tempA;
   


  }
  public int ListLength(ListNode head){
    ListNode temp=head;
    int count=0;
    while(temp!=null){
      count++;
      temp=temp.next;
    }
    return count;
  }
}