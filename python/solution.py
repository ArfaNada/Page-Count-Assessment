# solution.py

def pageCount(n: int, p: int) -> int:
    """
    Calculate the minimum number of pages to turn to reach page `p`
    in a book with `n` pages.

    You can start turning pages from the front or the back.
    Each page turn flips exactly one sheet (2 pages if possible).

    Args:
        n (int): Total number of pages in the book
        p (int): Target page number

    Returns:
        int: Minimum number of page turns required
    """
    # Calculate turns from the front (page 1)
    # Each turn reveals 2 pages, so divide by 2
    turns_from_front = p // 2
    
    # Calculate turns from the back
    # Total possible turns from front is n // 2
    # Subtract the target page position from that
    turns_from_back = n // 2 - p // 2
    
    # Special case: when n is divisible by 4 and p is n-1,
    # both pages n-1 and n are visible from the back opening
    if n % 4 == 0 and p == n - 1:
        turns_from_back = 0
    
    # Return the minimum of the two approaches
    return min(turns_from_front, turns_from_back)


def pageCountMultiple(n: int, targets: list[int]) -> list[int]:
    """
    Calculate the minimum number of pages to turn for multiple target pages
    in a book with `n` pages.

    Args:
        n (int): Total number of pages in the book
        targets (list[int]): List of target pages

    Returns:
        list[int]: List of minimum page turns for each target page
    """
    # Apply pageCount to each target page
    return [pageCount(n, p) for p in targets]