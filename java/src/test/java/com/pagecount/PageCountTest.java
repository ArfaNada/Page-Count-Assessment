package com.pagecount;

import org.junit.jupiter.api.Test;
import java.util.Arrays;
import java.util.List;
import static org.junit.jupiter.api.Assertions.*;

public class PageCountTest {

    // --- Part 1: Single page ---
    @Test
    void sampleCase1() {
        assertEquals(1, Result.pageCount(6, 2));
    }

    @Test
    void sampleCase2() {
        assertEquals(0, Result.pageCount(5, 4));
    }

    @Test
    void firstPage() {
        assertEquals(0, Result.pageCount(10, 1));
    }

    @Test
    void lastPageEven() {
        assertEquals(0, Result.pageCount(10, 10));
    }

    @Test
    void lastPageOdd() {
        assertEquals(0, Result.pageCount(9, 9));
    }

    @Test
    void middlePageFront() {
        assertEquals(1, Result.pageCount(7, 3));
    }

    @Test
    void middlePageBack() {
        assertEquals(1, Result.pageCount(7, 4));
    }

    @Test
    void pageNearStart() {
        assertEquals(1, Result.pageCount(100, 2));
    }

    @Test
    void pageNearEnd() {
        assertEquals(0, Result.pageCount(100, 99));
    }

    @Test
    void largeBookMiddle() {
        assertEquals(225, Result.pageCount(1000, 450));
    }

    @Test
    void largeBookNearEnd() {
        assertEquals(0, Result.pageCount(1000, 999));
    }

    // --- Part 2: Multiple queries ---
    @Test
    void multipleQueriesSmallBook() {
        List<Integer> targets = Arrays.asList(1, 2, 5, 6);
        List<Integer> expected = Arrays.asList(0, 1, 1, 0);
        assertEquals(expected, Result.pageCountMultiple(6, targets));
    }

    @Test
    void multipleQueriesLargeBook() {
        List<Integer> targets = Arrays.asList(2, 50, 99);
        List<Integer> expected = Arrays.asList(1, 25, 0);
        assertEquals(expected, Result.pageCountMultiple(100, targets));
    }

    @Test
    void singleTargetMultipleQueries() {
        List<Integer> targets = Arrays.asList(4);
        List<Integer> expected = Arrays.asList(2);
        assertEquals(expected, Result.pageCountMultiple(10, targets));
    }

    @Test
    void firstAndLastPageMultipleQueries() {
        List<Integer> targets = Arrays.asList(1, 15);
        List<Integer> expected = Arrays.asList(0, 0);
        assertEquals(expected, Result.pageCountMultiple(15, targets));
    }
}
