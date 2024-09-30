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
import { useState } from 'react';

interface Props {
  filters: string[] | null;
  filterName: string;
  checkedValue: string[];
  onChange: (items: string[]) => void;
}
const FilterProducts = ({
  filters,
  filterName,
  checkedValue,
  onChange,
}: Props) => {
  const [checkedItems, setcheckedItems] = useState(checkedValue || []);

  const handleCheckedItems = (item: string) => {
    const currentIndex = checkedItems.findIndex((i) => i === item);
    let newChecked: string[] = [];
    if (currentIndex === -1) newChecked = [...checkedItems, item];
    else newChecked = checkedItems.filter((i) => i !== item);
    setcheckedItems(newChecked);
    onChange(newChecked);
  };
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
                  control={
                    <Checkbox
                      checked={checkedValue.indexOf(filter) !== -1}
                      onChange={() => handleCheckedItems(filter)}
                    />
                  }
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
