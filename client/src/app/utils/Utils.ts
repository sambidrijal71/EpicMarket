export const currencyConverter = (currency: number) => {
  return `$${(currency / 100).toFixed(2)}`;
};

export const currencyAfterDiscount = (
  currency: number,
  discountPercentage: number
) => {
  return `$${((currency - (currency / 100) * discountPercentage) / 100).toFixed(
    2
  )}`;
};

export const capitalizeFirstLetter = (str: string) => {
  return str.charAt(0).toUpperCase() + str.slice(1);
};
