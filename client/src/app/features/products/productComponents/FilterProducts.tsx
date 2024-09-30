import { ExpandMoreOutlined } from '@mui/icons-material';
import {
  Accordion,
  AccordionDetails,
  AccordionSummary,
  Checkbox,
  FormControlLabel,
  FormGroup,
  Paper,
} from '@mui/material';

interface Props {
  filters: string[] | null;
  filterName: string;
}
const FilterProducts = ({ filters, filterName }: Props) => {
  return (
    <Paper sx={{ marginBottom: 2 }}>
      <Accordion>
        <AccordionSummary
          expandIcon={<ExpandMoreOutlined />}
          aria-controls='panel1-content'
          id='panel1-header'
        >
          Filter {filterName}
        </AccordionSummary>
        <AccordionDetails>
          <FormGroup>
            {filters &&
              filters.map((filter) => (
                <FormControlLabel
                  key={filter}
                  control={<Checkbox defaultChecked />}
                  label={filter}
                />
              ))}
          </FormGroup>
        </AccordionDetails>
      </Accordion>
    </Paper>
  );
};

export default FilterProducts;
