namespace nodejs {
  interface I4 {
    [index: string]: string;
  }

  let i4: I4 = {};
  i4["A1"] = "AA1";
  i4["A2"] = "AA2";
  console.log(i4);

  interface I5 {
    [index: number]: number;
  }

  let i5: I5 = [1, 2, 3, 4];
  console.log(i5);
  console.log(i5[0], i5[1]);

  i5[0] = 100;
  console.log(i5[0], i5[1]);
}
