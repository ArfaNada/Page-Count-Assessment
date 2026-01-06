package com.pagecount;

import java.util.List;
import java.util.ArrayList;

public class Result {

    /**
     * Returns the minimum number of pages to turn to reach page p
     * in a book with n pages.
     *
     * @param n Total number of pages in the book
     * @param p Target page
     * @return Minimum number of page turns
     */
    public static int pageCount(int n, int p) {
        // Calculate turns from the front (page 1)
        // Each turn reveals 2 pages, so divide by 2
        int turnsFromFront = p / 2;
        
        // Calculate turns from the back
        // Total possible turns from front is n / 2
        // Subtract the target page position from that
        int turnsFromBack = n / 2 - p / 2;
        
        // Special case: when n is divisible by 4 and p is n-1,
        // both pages n-1 and n are visible from the back opening
        if (n % 4 == 0 && p == n - 1) {
            turnsFromBack = 0;
        }
        
        // Return the minimum of the two approaches
        return Math.min(turnsFromFront, turnsFromBack);
    }

    /**
     * Returns an array of minimum page turns for multiple target pages.
     *
     * @param n Total number of pages in the book
     * @param targets Array of target pages
     * @return Array of minimum page turns for each target
     */
    public static int[] pageCountMultiple(int n, int[] targets) {
        int[] result = new int[targets.length];
        for (int i = 0; i < targets.length; i++) {
            result[i] = pageCount(n, targets[i]);
        }
        return result;
    }
    
    /**
     * Returns a list of minimum page turns for multiple target pages.
     *
     * @param n Total number of pages in the book
     * @param targets List of target pages
     * @return List of minimum page turns for each target
     */
    public static List<Integer> pageCountMultiple(int n, List<Integer> targets) {
        List<Integer> result = new ArrayList<>();
        for (int target : targets) {
            result.add(pageCount(n, target));
        }
        return result;
    }
}
