import { VizionUIPage } from './app.po';

describe('vizion-ui App', function() {
  let page: VizionUIPage;

  beforeEach(() => {
    page = new VizionUIPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
