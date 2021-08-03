using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class MergeSort
    {
       public static void mergeSort(int[] arr){
            int n =arr.Length;
                //base case
            if(n<2) return;  
            //find the midpoint of the array
            int mid = n/2;
        
            //create arrays for the left and right halves
            int[] left = new int[mid];
            int[] right = new int[n - mid];
            //if(n%2 == 0){
            //  right = new int[mid];
            //} else{
            //  right = new int[mid+1];
            //}

            //populate the left array
            for(int i=0;i<mid;i++){
              left[i] = arr[i];
            }

            //populate the right array
            int j =0;
            for(int i=mid;i<n;i++){
              right[j] = arr[i];
              j++;
            }

            mergeSort(left);  //recursively sort the left
            mergeSort(right);  //recursively sort the left
            merge(arr, left, right); // merge the two sorted arrays
        }
       public static void merge(int[] arr, int[] left,int[] right){
            int i = 0;
            int j = 0;
            int k = 0; 
            int nL = left.Length;
            int nR = right.Length;

            // while start is less than the end for both arrays
            while(i<nL && j<nR){
                if(left[i]<=right[j]){  // if item on the left is lesst than of the right
                    arr[k] = left[i];   // add the item at left to the arrand increment left index
                    i++;
                }else{
                    arr[k] = right[j];  // else item on the right will be added to the arr and increment the right idex
                    j++;
                }
                k++; // increment the arr index
            }
        
            //if only the left array still has elements, add all its elements to the arr
            while(i<nL){
                arr[k] = left[i];
                i++;
                j++;
            }

            //if only the right array still has elements, add all its elements to the arr
            while(j<nR){
                arr[k] = right[j];
                j++;
                k++;
            }
        } 
    }
}
