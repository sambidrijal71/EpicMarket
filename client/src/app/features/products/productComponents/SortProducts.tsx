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
}
const SortProducts = ({ sortProducts }: Props) => {
  return (
    <Paper sx={{ marginBottom: 2, p: 2 }}>
      <FormControl>
        <RadioGroup
          aria-labelledby='demo-radio-buttons-group-label'
          defaultValue='name'
          name='radio-buttons-group'
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
