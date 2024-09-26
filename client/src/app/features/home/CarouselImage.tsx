import Carousel from 'react-material-ui-carousel';
import { Paper } from '@mui/material';

const CarouselImage = () => {
  const randomGeneratedImages: string[] = [];
  for (let i = 0; i <= 8; i++) {
    randomGeneratedImages.push(Math.ceil(Math.random() * 10 + 1).toString());
  }
  return (
    <>
      <Carousel
        autoPlay={true}
        interval={3000}
        navButtonsProps={{
          style: {
            backgroundColor: '#131317',
            borderRadius: 0,
          },
        }}
        navButtonsWrapperProps={{
          style: {
            bottom: '0',
            top: 'unset',
          },
        }}
      >
        {randomGeneratedImages.map((image, index) => (
          <Paper
            key={index}
            sx={{
              height: '310px',
              display: 'flex',
              justifyContent: 'center',
              alignItems: 'center',
            }}
          >
            <img
              src={`/images/carouselImages/${image}.jpg`}
              style={{
                height: '300px',
                width: '98%',
                backgroundPosition: 'contained',
                padding: 4,
              }}
            />
          </Paper>
        ))}
      </Carousel>
    </>
  );
};

export default CarouselImage;
