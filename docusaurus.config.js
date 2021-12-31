/** @type {import('@docusaurus/types').DocusaurusConfig} */
module.exports = {
  title: 'Argent Pony Warcraft Classic Client',
  tagline: 'A .NET client for the Blizzard World of Warcraft Classic APIs',
  url: 'https://blizzard-net.github.io',
  baseUrl: '/warcraft-classic/',
  onBrokenLinks: 'throw',
  onBrokenMarkdownLinks: 'warn',
  favicon: 'img/favicon.ico',
  organizationName: 'blizzard-net', // Usually your GitHub org/user name.
  projectName: 'warcraft-classic', // Usually your repo name.
  themeConfig: {
    navbar: {
      title: 'Argent Pony Warcraft Classic Client',
      logo: {
        alt: 'Argent Pony Warcraft Classic Client Logo',
        src: 'img/ArgentPony.png',
      },
      items: [
        {
          to: 'docs/',
          activeBasePath: 'docs',
          label: 'Docs',
          position: 'left',
        },
        {to: 'blog', label: 'Blog', position: 'left'},
        {
          href: 'https://github.com/blizzard-net/warcraft-classic',
          label: 'GitHub',
          position: 'right',
        },
      ],
    },
    footer: {
      style: 'dark',
      links: [
        {
          title: 'Docs',
          items: [
            {
              label: 'Getting Started',
              to: 'docs/',
            },
          ],
        },
        {
          title: 'Community',
          items: [
            {
              label: 'Discussions',
              href: 'https://github.com/blizzard-net/warcraft-classic/discussions',
            },
          ],
        },
        {
          title: 'More',
          items: [
            {
              label: 'Blog',
              to: 'blog',
            },
            {
              label: 'GitHub',
              href: 'https://github.com/blizzard-net/warcraft-classic',
            },
          ],
        },
      ],
      copyright: `Copyright © ${new Date().getFullYear()} Argent Pony Warcraft Classic Client contributors`,
    },
    prism: {
      additionalLanguages: ['csharp'],
      theme: require('prism-react-renderer/themes/vsDark'),
    },
  },
  presets: [
    [
      '@docusaurus/preset-classic',
      {
        docs: {
          sidebarPath: require.resolve('./sidebars.js'),
          // Please change this to your repo.
          editUrl:
            'https://github.com/blizzard-net/warcraft-classic/edit/documentation/',
        },
        blog: {
          showReadingTime: true,
          // Please change this to your repo.
          editUrl:
            'https://github.com/blizzard-net/warcraft-classic/edit/documentation/blog/',
        },
        theme: {
          customCss: require.resolve('./src/css/custom.css'),
        },
      },
    ],
  ],
};
