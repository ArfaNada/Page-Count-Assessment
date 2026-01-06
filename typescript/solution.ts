/**
 * Returns the minimum number of pages to turn to reach page `p`
 * in a book with `n` pages.
 *
 * @param n - Total number of pages in the book
 * @param p - Target page
 * @returns Minimum number of page turns
 */
export function pageCount(n: number, p: number): number {
    // Calculate turns from the front (page 1)
    // Each turn reveals 2 pages, so divide by 2
    const turnsFromFront = Math.floor(p / 2);
    
    // Calculate turns from the back
    // Total possible turns from front is n // 2
    // Subtract the target page position from that
    let turnsFromBack = Math.floor(n / 2) - Math.floor(p / 2);
    
    // Special case: when n is divisible by 4 and p is n-1,
    // both pages n-1 and n are visible from the back opening
    if (n % 4 === 0 && p === n - 1) {
        turnsFromBack = 0;
    }
    
    // Return the minimum of the two approaches
    return Math.min(turnsFromFront, turnsFromBack);
}

/**
 * Returns the minimum number of pages to turn for multiple target pages.
 *
 * @param n - Total number of pages in the book
 * @param targets - Array of target pages
 * @returns Array of minimum page turns for each target
 */
export function pageCountMultiple(n: number, targets: number[]): number[] {
    // Apply pageCount to each target page
    return targets.map(p => pageCount(n, p));
}