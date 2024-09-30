import {
  FormControl,
  FormControlLabel,
  Paper,
  Radio,
  RadioGroup,
} from '@mui/material';

interface SortOption {
  label: string;
  value: string;
}
interface Props {
  sortProducts: SortOption[];
  handleSortOption: (e: any) => void;
  selectedValue: string;
}
const SortProducts = ({
  sortProducts,
  handleSortOption,
  selectedValue,
}: Props) => {
  return (
    <Paper sx={{ marginBottom: 2, p: 2 }}>
      <FormControl>
        <RadioGroup
          aria-labelledby='demo-radio-buttons-group-label'
          defaultValue={selectedValue}
          name='radio-buttons-group'
          onChange={handleSortOption}
        >
          {sortProducts.map(({ label, value }) => (
            <FormControlLabel
              value={value}
              control={<Radio />}
              label={label}
              key={value}
            />
          ))}
        </RadioGroup>
      </FormControl>
    </Paper>
  );
};

export default SortProducts;
