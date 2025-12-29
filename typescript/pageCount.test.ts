import { pageCount, pageCountMultiple } from "./solution";

describe("pageCount", () => {
  // --- Part 1: Single page ---
  test("sample case: n=6, p=2", () => {
    expect(pageCount(6, 2)).toBe(1);
  });

  test("sample case: n=5, p=4", () => {
    expect(pageCount(5, 4)).toBe(0);
  });

  test("first page", () => {
    expect(pageCount(10, 1)).toBe(0);
  });

  test("last page even", () => {
    expect(pageCount(10, 10)).toBe(0);
  });

  test("last page odd", () => {
    expect(pageCount(9, 9)).toBe(0);
  });

  test("middle page front", () => {
    expect(pageCount(7, 3)).toBe(1);
  });

  test("middle page back", () => {
    expect(pageCount(7, 4)).toBe(1);
  });

  test("page near start", () => {
    expect(pageCount(100, 2)).toBe(1);
  });

  test("page near end", () => {
    expect(pageCount(100, 99)).toBe(0);
  });

  test("large book middle", () => {
    expect(pageCount(1000, 450)).toBe(225);
  });

  test("large book near end", () => {
    expect(pageCount(1000, 999)).toBe(0);
  });
});

describe("pageCountMultiple", () => {
  // --- Part 2: Multiple queries ---
  test("small book multiple targets", () => {
    expect(pageCountMultiple(6, [1, 2, 5, 6])).toEqual([0, 1, 1, 0]);
  });

  test("large book multiple targets", () => {
    expect(pageCountMultiple(100, [2, 50, 99])).toEqual([1, 25, 0]);
  });

  test("single target in multiple queries", () => {
    expect(pageCountMultiple(10, [4])).toEqual([2]);
  });

  test("first and last page multiple queries", () => {
    expect(pageCountMultiple(15, [1, 15])).toEqual([0, 0]);
  });
});
