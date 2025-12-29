# test_page_count.py
import unittest
from solution import pageCount, pageCountMultiple

class TestPageCount(unittest.TestCase):
    # --- Part 1: Single page ---
    def test_sample_case_1(self):
        self.assertEqual(pageCount(6, 2), 1)

    def test_sample_case_2(self):
        self.assertEqual(pageCount(5, 4), 0)

    def test_first_page(self):
        self.assertEqual(pageCount(10, 1), 0)

    def test_last_page_even(self):
        self.assertEqual(pageCount(10, 10), 0)

    def test_last_page_odd(self):
        self.assertEqual(pageCount(9, 9), 0)

    def test_middle_page(self):
        self.assertEqual(pageCount(7, 3), 1)

    def test_middle_page_from_back(self):
        self.assertEqual(pageCount(7, 4), 1)

    def test_page_near_start(self):
        self.assertEqual(pageCount(100, 2), 1)

    def test_page_near_end(self):
        self.assertEqual(pageCount(100, 99), 0)

    def test_large_book_middle(self):
        self.assertEqual(pageCount(1000, 450), 225)

    def test_large_book_near_end(self):
        self.assertEqual(pageCount(1000, 999), 0)

    # --- Part 2: Multiple queries ---
    def test_multiple_queries_small_book(self):
        n = 6
        targets = [1, 2, 5, 6]
        expected = [0, 1, 1, 0]
        self.assertEqual(pageCountMultiple(n, targets), expected)

    def test_multiple_queries_large_book(self):
        n = 100
        targets = [2, 50, 99]
        expected = [1, 25, 0]
        self.assertEqual(pageCountMultiple(n, targets), expected)

    def test_multiple_queries_single_target(self):
        n = 10
        targets = [4]
        expected = [2]
        self.assertEqual(pageCountMultiple(n, targets), expected)

    def test_multiple_queries_first_last_pages(self):
        n = 15
        targets = [1, 15]
        expected = [0, 0]
        self.assertEqual(pageCountMultiple(n, targets), expected)


if __name__ == '__main__':
    unittest.main()
